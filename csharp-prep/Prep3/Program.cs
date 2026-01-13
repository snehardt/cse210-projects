using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guessCounter = 1;
        Console.WriteLine("I'm thinking of a magical number between 1 and 10.");
        Console.Write("What is your guess?: ");
        string userInput = Console.ReadLine();
        int guess = int.Parse(userInput);
        while (guess != number)
            {
            guessCounter += 1;
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess?: ");
            string userRepeat = Console.ReadLine();
            guess = int.Parse(userRepeat);
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {guessCounter} guesses.");
    }
}