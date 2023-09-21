using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int done = 2;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (done != 0)
        {
            Console.WriteLine("Enter number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            done = userNumber;
            numbers.Add(userNumber);
        } 
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number; 
        }
        int average = sum / numbers.Count;
         int large = 0;
         int count;
         foreach (int number in numbers)
         {
            if (number > large)
            {
                large = number;
            }
            else 
            {
                count =+ 1;
            }
         }

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {large}");

    }
}