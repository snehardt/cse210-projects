using System;
using System.Threading;

public static class Text
{
    public static void TypeText(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(10);
        }
        Console.WriteLine();
    }

    public static void WaitForEnter()
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}