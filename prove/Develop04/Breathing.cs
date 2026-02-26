using System;
using System.Threading.Tasks.Dataflow;

class Breathing : Activity
{
    public Breathing() 
    : base ("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    public void Run()
    {
        StartActivity();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowTimer(4);

            if (DateTime.Now >= endTime)
                break;

            Console.Write("Now breathe out... ");
            ShowTimer(5);
        }
        EndActivity();
    }
}