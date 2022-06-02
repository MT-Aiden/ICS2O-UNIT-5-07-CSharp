// Aiden McLeod
// ICS2O-Unit5-07-CSharp
// May 11 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int integer;
        int answer;
        int counter = 1;
        string text = "1";

        Console.WriteLine("Enter integer:");
        while (!int.TryParse(Console.ReadLine(), out integer))
        {
            Console.WriteLine("Error 2: This isn't an integer.");
            Environment.Exit(0);
            answer = 0;
        }
        if (integer < 0)
        {
            Console.WriteLine("Error 1: This integer is negative.");
            Environment.Exit(0);
            answer = 0;
        }
        else if (integer == 0)
        {
            answer = 0;
            text = "nothing.";
        }
        else
        {
            answer = 1;
            for (int count = 1; count < integer; count++)
            {
                counter++;
                text = text + " + " + counter;
                answer = answer + counter;
            }
        }
        Console.WriteLine("\n" + answer);
        Console.WriteLine("is the answer of " + text);
        Console.WriteLine("\nFinished.");
    }
}