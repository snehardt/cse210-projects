class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override void Display()
    {
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
    }
    public override string FormatGoal()
    {
        return $"Eternal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}