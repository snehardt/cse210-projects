class ActivityLog
{
    private static int _breathingCount = 0;
    private static int _reflectionCount = 0;
    private static int _listingCount = 0;
    private static int _totalTime = 0;

    public static void Log(string name, int duration)
    {
        if (name == "Breathing")
            _breathingCount++;
        else if (name == "Reflection")
            _reflectionCount++;
        else if (name == "Listing")
            _listingCount++;

        _totalTime += duration;
    }

    public static void DisplayLog()
    {
        Console.Clear();
        Console.WriteLine("Activity Log");
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"Breathing completed:    {_breathingCount} times");
        Console.WriteLine($"Reflection completed:   {_reflectionCount} times");
        Console.WriteLine($"Listing completed:      {_listingCount} times");
        Console.WriteLine($"Total time spent:       {_totalTime} seconds");
        Console.WriteLine("-------------------------------");
        Console.WriteLine();
        Console.WriteLine("Press Enter to go back to the Menu");
        Console.ReadLine();
    }
}