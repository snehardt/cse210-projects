using System;

class Program
{

    // I added an activity Log tracker to the program to allow others to see how many times they've done each activity
    // I also made it so they can see the total time they've spent on activities
    // Then I updated the menu for them to access it
    static void Main(string[] args)
    {
        string input = "";
        ActivityLog log = new ActivityLog();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflection Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. View Activity Log");
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();

            if (input == "1")
            {
                Breathing breathing = new Breathing();
                breathing.Run();
            }
            else if (input == "2")
            {
                Reflection reflection = new Reflection();
                reflection.Run();
            }
            else if (input == "3")
            {
                Listing listing = new Listing();
                listing.Run();
            }
            else if (input == "4")
            {
                ActivityLog.DisplayLog();
            }
            else if (input == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please enter a number! Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}