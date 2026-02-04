using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Fraction f5 = new Fraction();
        Random rand = new Random();
        for (int i = 0; i < 20; i++)
        {
            int randTop = rand.Next(1, 20);
            int randBottom = rand.Next(1, 20);

            f5.SetTop(randTop);
            f5.SetBottom(randBottom);

            Console.WriteLine($"Fraction {i + 1}: string: {f5.GetFractionString()} decimal: {f5.GetDecimalValue()}");
        }
    }
}