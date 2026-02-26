using System;

class Listing : Activity
{
    private List<string> _prompts;
    private Random _rand;

    public Listing()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _rand = new Random();
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowTimer(5);

        int count = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");

        EndActivity();
    }
}