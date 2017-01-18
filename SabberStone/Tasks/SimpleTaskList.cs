namespace SabberStone.Tasks
{
    //public class SimpleTaskList<T> : List<T>, ISimpleTask where T : ISimpleTask
    //{
    //    private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    //    public Game Game { get; set; }
    //    private int _controllerId;
    //    public Controller Controller
    //    {
    //        get { return Game.ControllerById(_controllerId); }
    //        set { _controllerId = value.Id; }
    //    }
    //    private int _sourceId;
    //    public IEntity Source
    //    {
    //        get { return Game.IdEntityDic[_sourceId]; }
    //        set { _sourceId = value.Id; }
    //    }
    //    private int _targetId;
    //    public IEntity Target
    //    {
    //        get { return _targetId > -1 ? Game.IdEntityDic[_targetId] : null; }
    //        set { _targetId = value?.Id ?? -1; }
    //    }

    //    public List<IPlayable> Playables { get; set; }
    //    public bool Flag { get; set; }
    //    public int Number { get; set; }

    //    public List<Game> Splits { get; set; } = new List<Game>();
    //    public IEnumerable<IEnumerable<IPlayable>> Sets { get; set; }

    //    public bool Process()
    //    {
    //        // at the start move over initial parameters ...
    //        var validTask = true;
    //        Playables = Playables ?? new List<IPlayable>();
    //        for (var i = 0; i < Count && validTask; i++)
    //        {
    //            ISimpleTask task = this[i];
    //            task.Game = Game;
    //            task.Controller = Controller;
    //            task.Source = Source;
    //            task.Target = Target;
    //            task.Playables = Playables;
    //            task.Flag = Flag;
    //            task.Number = Number;

    //            task.Splits = Splits;
    //            task.Sets = Sets;

    //            // execution
    //            validTask &= task.Process();

    //            // move over in queue
    //            Game = task.Game;
    //            Controller = task.Controller;
    //            Source = task.Source;
    //            Target = task.Target;
    //            Playables = task.Playables;
    //            Flag = task.Flag;
    //            Number = task.Number;

    //            Splits = task.Splits;
    //            Sets = task.Sets;
    //        }
    //        return validTask;
    //    }

    //    public ISimpleTask Clone()
    //    {
    //        var cloneList = new SimpleTaskList<ISimpleTask>();
    //        cloneList.Copy(this);
    //        ForEach(p => cloneList.Add(p.Clone()));
    //        return cloneList;
    //    }

    //    public static SimpleTaskList<ISimpleTask> Chain(params ISimpleTask[] list)
    //    {
    //        var newList = new SimpleTaskList<ISimpleTask>();
    //        newList.AddRange(list);
    //        return newList;
    //    }

    //    public void Copy(ISimpleTask task)
    //    {
    //        if (task.Game != null)
    //        {
    //            Game = task.Game;
    //            Controller = task.Controller;
    //            Source = task.Source;
    //            Target = task.Target;
    //        }
    //        Playables = task.Playables;
    //        Flag = task.Flag;
    //        Number = task.Number;

    //        Splits = task.Splits;
    //        Sets = task.Sets;
    //    }

    //    public void Reset()
    //    {
    //        Playables = new List<IPlayable>();
    //        Flag = false;
    //        Number = 0;

    //        Splits = new List<Game>();
    //        Sets = null;

    //        // reset its chain ...
    //        ForEach(p => p.Reset());
    //    }
    //}
}