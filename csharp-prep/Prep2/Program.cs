using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Final Grade persentage? ");
        string persentage = Console.ReadLine();
        int grade = int.Parse(persentage);
        if (grade >= 90)
        {
            Console.WriteLine("Your final letter grade Is A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your final letter grade Is B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your final letter grade Is C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your final letter grade Is D");
        }
        else if (grade < 50)
        {
            Console.WriteLine("Your final letter grade Is F");
        }
        else
        {
            Console.WriteLine("That is not an acceptable grade. Make sure you only provide whole numbers");
        }
    }
}