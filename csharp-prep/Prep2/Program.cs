using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is you grade percetage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >=70)
        {
            letter = "C";
        }
        else if (grade >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is a {letter}.");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congradulations! You have passed the class!");
        }
        else
        {
            Console.WriteLine("I'm sorry, better luck next time.");
        }
    }
}