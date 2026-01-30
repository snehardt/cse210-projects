using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        I decided to add a gratitude journal entry because sometimes
         theres not a lot to write. There's no pressure to write a 
         lot if you just write three things. It can also be helpful 
         to build a habit.
         */
         
        Journal journal = new Journal();

        bool stop = false;
        while (!stop){
            
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Gratitude Entry");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                PromptMaker promptMaker = new PromptMaker();
                string prompt = promptMaker.GetPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string userPrompt = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._prompt = prompt;
                newEntry._userResponse = userPrompt;

                journal.AddEntry(newEntry);
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Write 3 things you are grateful for today:");

                Console.Write("1. ");
                string g1 = Console.ReadLine();

                Console.Write("2. ");
                string g2 = Console.ReadLine();

                Console.Write("3. ");
                string g3 = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._prompt = "Gratitude List";
                newEntry._userResponse = $"{g1}, {g2}, {g3}";
                
                journal.AddEntry(newEntry);
                Console.WriteLine("Gratitude entry saved!\n");
            }
            else if (userInput == "3")
            {
                journal.DisplayJournal();
            }
            else if (userInput == "4")
            {
                Console.Write("Enter Filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded!\n");
            }
            else if (userInput == "5")
            {
                Console.Write("Enter FIlename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);

                Console.WriteLine("Entry saved!\n");
            }
            else if (userInput == "6")
            {
                stop = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please type a number.");
                Console.WriteLine();
            }
        }
    }
}