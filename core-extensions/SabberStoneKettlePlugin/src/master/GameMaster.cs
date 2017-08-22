using Kettle.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace SabberStoneKettlePlugin.master
{
    /// <summary>
    /// Object which controls all game instances.
    /// </summary>
    internal class GameMaster
    {
        private readonly Semaphore _instanceCounter;
        private readonly Dictionary<int, Semaphore> _instancesPerSlave;
        private readonly int _maxSlaves;
        private readonly int _maxInstancesPerSlave;
        private readonly List<int> _slaveIDs;
        private int _rrSlaveID;
        private object _slaveSelectorLock;

        /* 
         * TODO; Change the approach of calculating average game time, 
         * maybe a sliding average with outlier detection+prevention.
         * 
         */
        private long _totalGameTimeSeconds;
        private int _countedGames;
        private object _gameTimeLock;

        public GameMaster(int maxInstances, int maxSlaves, int maxInstancesPerSlave)
        {
            Debug.Assert(maxInstances > 0);
            Debug.Assert(maxSlaves > 0);
            Debug.Assert(maxInstancesPerSlave > 0);

            _instanceCounter = new Semaphore(0, maxInstances);
            _instancesPerSlave = new Dictionary<int, Semaphore>();
            _maxSlaves = maxSlaves;
            _maxInstancesPerSlave = maxInstancesPerSlave;
            _slaveIDs = new List<int>();
            _rrSlaveID = 0;
            _slaveSelectorLock = new object();

            _totalGameTimeSeconds = 0;
            _countedGames = 0;
            _gameTimeLock = new object();
        }

        /// <summary>
        /// Setups additional framework slave connections.
        /// The framework initialises with exactly 1 slave.
        /// We raise this value until we have the given amount of slaves available.
        /// 
        /// This method can only be called when 
        /// </summary>
        private bool SetupFrameworkSlaveConnections()
        {
            if (_slaveIDs.Count > 0) return false;
            if (KettleFramework.IsSlave()) return false;

            try
            {
                // We first check the already present descriptors because other code
                // might have initialised slaves in a specific way or to test slave
                // connectivity!

                var slaveDescriptors = KettleFramework.IPCConnectedDescriptors;
                // Only loop until we have the desired amount of slaves registered.
                // It's not our task to care about the abundant amount of slaves (if 
                // there are).
                for (int i = 0; i < _maxSlaves; ++i)
                {
                    if (i < slaveDescriptors.Count)
                    {
                        // First register all slaves which were initialised by the framework.
                        var descr = slaveDescriptors[i];
                        RegisterSlave(descr.ID);
                    }
                    else
                    {
                        // Create new slaves and register them.
                        var connectResult = KettleFramework.StartSlaveAsync().Result;
                        if (!connectResult.Result)
                        {
                            return false;
                        }

                        var descriptor = connectResult.Data;
                        RegisterSlave(descriptor.ID);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Initialises the GameMaster object.
        /// </summary>
        /// <returns></returns>
        protected bool GameMasterInit()
        {
            return SetupFrameworkSlaveConnections();
        }

        /// <summary>
        /// Attempts to allocate a game instance slot.
        /// The slave which has to run the game is returned by the parameter `slaveID`.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if tha new game instance slot was allocated; otherwise, <c>false</c>.
        /// </returns>
        public bool RegisterNewGameInstance(out int slaveID)
        {
            // Threadsafe way of increasing the instance counter.
            // If this returns true, the instance counter has also been updated.
            // If this returns false, the instance counter was (and stayed) at the maximum allowed 
            // instances for this process.
            if (_slaveIDs.Count == 0 || !_instanceCounter.WaitOne(0))
            {
                slaveID = -1;
                return false;
            }

            // Select a slave for maintaining the game.
            lock (_slaveSelectorLock)
            {
                _rrSlaveID = (++_rrSlaveID) % _slaveIDs.Count;
                slaveID = _slaveIDs[_rrSlaveID];
                var slaveSem = _instancesPerSlave[slaveID];
                if (!slaveSem.WaitOne(0))
                {
                    Debug.Fail("Desynchronization between instance counter and slave counters!");
                    return false;
                }
                return true;
            }
        }

        public bool UnregisterGameInstance(int slaveID)
        {
            if (_instancesPerSlave.ContainsKey(slaveID)) return false;

            try
            {
                // Decrease global counter.
                _instanceCounter.Release();
                // Decrease counter per slave.
                _instancesPerSlave[slaveID].Release();
                return true;
            }
            catch (Exception e)
            {
                if (e is SemaphoreFullException)
                {
                    Debug.Fail("Inbalance in game allocations!");
                    return false;
                }

                throw;
            }
        }

        public bool RegisterSlave(int slaveID)
        {
            if (_slaveIDs.Count >= Program.MaxSlaves) return false;
            if (_instancesPerSlave.ContainsKey(slaveID)) return false;

            lock (_slaveSelectorLock)
            {
                _instancesPerSlave[slaveID] = new Semaphore(0, _maxInstancesPerSlave);
                _slaveIDs.Add(slaveID);
            }
            return true;
        }

        public bool RemoveSlave(int slaveID)
        {
            if (_instancesPerSlave.Remove(slaveID))
            {
                lock (_slaveSelectorLock)
                {
                    _slaveIDs.Remove(slaveID);
                }
                return true;
            }

            return false;
        }

        public void LogGameTime(int gametimeSeconds)
        {
            lock (_gameTimeLock)
            {
                _totalGameTimeSeconds += gametimeSeconds;
                _countedGames++;
            }
        }

        public double AverageQueueTime()
        {
            if (_countedGames == 0) return 0.0;

            double doubleGameTime = _totalGameTimeSeconds;
            double doubleCountedGames = _countedGames;
            return doubleGameTime / doubleCountedGames;
        }
    }
}
