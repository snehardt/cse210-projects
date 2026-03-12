using System;
using System.IO;

class Program
{

    // I have added a leveling up system to the code
    // Whenever you reach a certain point amount, you can level up
    // To make it easier on the user, you can see how many points you need to move 
    // to a new rank. I also make it possible to keep track of how
    // many times you've completed goals. 
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        Leveling level = new Leveling();
        int currentPoints = 0;
        int goalsCompleted = 0;
        string currnetRank = level.GetRank(currentPoints);

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {currentPoints} points");
            Console.WriteLine($"Rank: {level.GetRank(currentPoints)}");
            Console.WriteLine($"Goals Completed: {goalsCompleted}");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Leveling up");
            Console.WriteLine(" 7. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine(" 1. Simple Goal ");
                    Console.WriteLine(" 2. Eternal Goal ");
                    Console.WriteLine(" 3. Checklist Goal ");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalChoice = Console.ReadLine();

                    if (goalChoice != "1" && goalChoice != "2" && goalChoice != "3")
                    {
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                    }

                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    switch (goalChoice)
                    {
                        case "1":
                            OneTime oneTimeGoal = new OneTime(name, description, points);
                            goals.Add(oneTimeGoal);
                            break;
                        case "2":
                            Eternal eternalGoal = new Eternal(name, description, points);
                            goals.Add(eternalGoal);
                            break;
                        case "3":
                            Console.Write("How many times does this goal need to accomplished for a bonus? ");
                            int timesToComplete = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            MultiGoal multiGoalGoal = new MultiGoal(name, description, points, timesToComplete, bonusPoints);
                            goals.Add(multiGoalGoal);
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("The goals are: ");
                    int goalNum = 1;
                    foreach (Goal goal in goals)                    
                    {
                        Console.Write($"{goalNum}. ");
                        goal.Display();
                        goalNum += 1;
                    }
                    Console.WriteLine();
                    break;

                case "3":
                    Console.Write("What is the filename for the goal file? ");
                    string saveFile = Console.ReadLine();

                    using (StreamWriter output = new StreamWriter(saveFile))
                    {
                        output.WriteLine(currentPoints);
                        output.WriteLine(goalsCompleted);

                        foreach (Goal goal in goals)
                        {
                            output.WriteLine(goal.FormatGoal());
                        }
                    }
                    Console.WriteLine("File saved successfully!");
                    break;

                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    string loadFile = Console.ReadLine();

                    string[] lines = File.ReadAllLines(loadFile);
                    goals.Clear();

                    currentPoints = int.Parse(lines[0]);
                    goalsCompleted = int.Parse(lines[1]);
                    currnetRank = level.GetRank(currentPoints);

                    for (int i = 2; i < lines.Length; i++)
                    {
                        string line = lines[i];

                        string[] parts = line.Split(":");
                        string goalType = parts[0];
                        string[] data = parts[1].Split(",");

                        if (goalType == "OneTime")
                        {
                            OneTime goal = new OneTime(data[0], data[1], int.Parse(data[2]));

                            bool complete = bool.Parse(data[3]);
                            goal.Complete(complete);

                            goals.Add(goal);
                        }
                        else if (goalType == "Eternal")
                        {
                            Eternal goal = new Eternal(data[0], data[1], int.Parse(data[2]));
                            goals.Add(goal);
                        }
                        else if (goalType == "MultiGoal")
                        {
                            MultiGoal goal = new MultiGoal(
                                data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3])
                            );

                            goal.Progress(int.Parse(data[5]));
                            goals.Add(goal);
                        }
                    }
                    Console.WriteLine("Goals loaded successfully!");
                    Console.WriteLine($"Rank restored: {level.GetRank(currentPoints)}");
                    break;

                case "5":
                    Console.Write("Which goal did you accomplish? ");
                    int completed = int.Parse(Console.ReadLine());
                    if (completed < 1 || completed > goals.Count)
                    {
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                    }
                    int addPoints = goals[completed - 1].RecordEvent();

                    if (addPoints > 0)
                    {
                        goalsCompleted++;
                    }
                    else
                    {
                        Console.WriteLine("This goal is already completed.");
                        break;
                    }

                    Console.WriteLine($"Congratulations! You have earned {addPoints} points!");
                    Console.WriteLine($"You also have finished another goal!");
                    currentPoints += addPoints;

                    string newRank = level.GetRank(currentPoints);
                    if (newRank != currnetRank)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Congratulations! You leveled up! Your new rank: {newRank}!");
                        Console.WriteLine();
                        currnetRank = newRank;
                    } 

                    Console.WriteLine($"You now have {currentPoints} points, with {goalsCompleted} goals completed!");

                    break;

                case "6":
                    level.ShowLevels();
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}