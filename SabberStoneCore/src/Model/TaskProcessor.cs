//using System;
//using System.Collections.Generic;
//using System.Text;
//using SabberStoneCore.Tasks;

//namespace SabberStoneCore.Model
//{
//    internal class TaskProcessor
//    {
//		private readonly Game _game;
//		private readonly Stack<Queue<ISimpleTask>> _eventStack;
//		private readonly Queue<ISimpleTask> _baseQueue;

//	    private Queue<ISimpleTask> CurrentQueue => _eventStack.Count == 0 ? _baseQueue : _eventStack.Peek();

//	    public void StartEvent()
//	    {
//		    if (CurrentQueue.Count != 0)
//			    _eventStack.Push(new Queue<ISimpleTask>());
//	    }

//	    public void Enqueue()
//	    {
			
//	    }

//	    public void Process()
//	    {

//	    }

//	    public void Execute()
//	    {

//	    }

//		public void Clone()
//	    {

//	    }
//    }
//}
