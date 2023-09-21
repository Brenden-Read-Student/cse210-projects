using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        int response = 0;
        int magiNumber = r.Next(0, 100);
        Console.WriteLine("What is the magic number? ");
        //string guessOnepork = Console.ReadLine();
        //response = int.Parse(guessOnepork);
        while (response != magiNumber)
        {

        Console.WriteLine("What is your guess? ");
        string guessOne = Console.ReadLine();
        response = int.Parse(guessOne);
        if (response == magiNumber)
        {
            Console.WriteLine("You guessed it!");
            break;
        }
        else if (response > magiNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (response < magiNumber)
        {
            Console.WriteLine("Higher");
        }
        }
    }
}