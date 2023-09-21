using System;
using System.Globalization;

// ask about problem on prep 4
//and about Squaring numbers in C#.
// also try to ask about common github problems when starting VS code.
//try this
class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        double sqNumber = SquareNumber(userNumber);
        DisplayResult(userName, sqNumber);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorit number(must be a whole number)? ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);
        return grade;
    }
    static double SquareNumber( int number)
    {
        double num = number*number;
        return num;
    }
    static void DisplayResult(string name, double squar)
    {
        Console.WriteLine($"{name}, the square of your number is {squar}");
    }

}