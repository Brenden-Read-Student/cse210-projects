using System;

class Program
{
    static void Main(string[] args)
    {
        string first_name = Console.ReadLine();
        Console.WriteLine("What is your first name?");
        string last_name = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        Console.WriteLine(" ");
        Console.Write($"Your name is {first_name}, {last_name} {first_name}");
    }
}