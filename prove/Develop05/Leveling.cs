class Leveling
{
    public string GetRank(int points)
    {
        if (points >= 1000)
        {
            return "Master";
        }
        else if (points >= 500)
        {
            return "Champion";
        }
        else if (points >= 200)
        {
            return "Adventurer";
        }
        else
        {
            return "Beginner";
        }
    }
    public void ShowLevels()
    {
        Console.WriteLine("Level Requirements:");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Beginner:    0 - 199 points");
        Console.WriteLine("Adventurer:  200 - 499 points");
        Console.WriteLine("Champion:    500 - 999 points");
        Console.WriteLine("Master:      1000+ points");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
}