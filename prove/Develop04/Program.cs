using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("Please select one of the following options");
        Console.WriteLine("1. Breathing ");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");

        string uInput = Console.ReadLine();
        switch (uInput)
        {
            case "1":
            //call breathing class
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
            Breathing Breathing = new Breathing();
            Breathing.breathing();
            break;

            case "2":
            //call reflection class
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Relflection Relflection = new Relflection();
            Relflection.reflections();
            break;

            case "3":
            //call Listing class
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Listing Listing = new Listing();
            Listing.ListingAct();
            break;

            default:
            Console.WriteLine("That was not an option. Please try again.");
            break;
        }
    }
}