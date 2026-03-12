class MultiGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonusPoints;

    public MultiGoal(string name, string description, int points, int timesToComplete, int bonusPoints) : base(name, description, points)
    {
        _timesToComplete = timesToComplete;
        _timesCompleted = 0;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted >= _timesToComplete)
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }

        _timesCompleted++;
        int earnedPoints = GetPoints();

        if (_timesCompleted == _timesToComplete)
        {
            earnedPoints += _bonusPoints;
        }

        return earnedPoints;
    }

    public void Progress(int completed)
    {
        _timesCompleted = completed;
    }

    public override void Display()
    {
        string status = _timesCompleted >= _timesToComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_timesToComplete}");
    }
    public override string FormatGoal()
    {
        return $"MultiGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonusPoints},{_timesToComplete},{_timesCompleted}";
    }
}