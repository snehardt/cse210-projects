class OneTime : Goal
{
    bool _isComplete;

    public OneTime(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public void Complete(bool complete)
    {
        _isComplete = complete;
    }
    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }

        _isComplete = true;
        return GetPoints();
    }
    public override void Display()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GetName()} ({GetDescription()})");
    }
    public override string FormatGoal()
    {
        return $"OneTime:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}