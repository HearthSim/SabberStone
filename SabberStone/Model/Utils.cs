using System;
using System.Collections.Generic;
using System.Linq;
using log4net;
using log4net.Core;

namespace SabberStone.Model
{
    public class Util
    {
        public static Random Random = new Random();

        public static T RandomElement<T>(IEnumerable<T> e)
            => e.ElementAt(Random.Next(0, e.Count()));

        public static IEnumerable<IEnumerable<T>> GetPowerSet<T>(List<T> list)
            => Enumerable.Range(0, 1 << list.Count)
                .Select(m => (from i in Enumerable.Range(0, list.Count)
                              where (m & (1 << i)) != 0 select list[i]));

        public static IEnumerable<IEnumerable<T>> GetDiscoverSets<T>(List<T> list)
        {
            var result = new List<IEnumerable<T>>();
            for (var i = 0; i < list.Count-2; i++)
            {
                var eleA = list[i];
                for (var j = i + 1; j < list.Count-1; j++)
                {
                    var eleB = list[j];
                    for (var k = j + 1; k < list.Count; k++)
                    {
                        result.Add(new[] {eleA, eleB, list[k] });
                    }
                }
            }
            return result;
        }

        public static void LogOn(bool flag)
        {
            foreach (var repository in LogManager.GetAllRepositories())
                repository.Threshold = flag ? Level.Info : Level.Off;
        }

        /// <summary>
        /// This can be used for caching values ... ex. scoring
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="getValue"></param>
        /// <returns></returns>
        public static Func<T> Remeber<T>(Func<T> getValue)
        {
            var isCached = false;
            var cachedResult = default(T);

            return () =>
            {
                if (isCached) return cachedResult;
                cachedResult = getValue();
                isCached = true;
                return cachedResult;
            };
        }

    }

    public class Util<T>
    {       
        public static T Choose(List<T> list) => list[Util.Random.Next(0, list.Count)];
    }
}
