using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Final Grade persentage? ");
        string persentage = Console.ReadLine();
        int grade = int.Parse(persentage);
        string letter;
        if (grade >= 90)
        {
            letter = "Your final letter grade is A";
        }
        else if (grade >= 80)
        {
            letter = "Your final letter grade is B";
        }
        else if (grade >= 70)
        {
            letter = "Your final letter grade is C";
        }
        else if (grade >= 60)
        {
            letter = "Your final letter grade is D";
        }
        else if (grade < 50)
        {
            letter = "Your final letter grade is F";
        }
        else
        {
            letter = "That is not an acceptable grade. Make sure you only provide whole numbers";
        }
        Console.WriteLine($"{letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations You passed the class!");
        }
        else
        {
            Console.WriteLine("It is time to start grinding, you did not pass but you can if you work hard.");
        }
    }
}