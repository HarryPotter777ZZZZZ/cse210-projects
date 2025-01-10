using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the first name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        
        // Ask for the family bane
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}