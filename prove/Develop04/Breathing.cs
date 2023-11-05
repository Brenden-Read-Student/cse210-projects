using System;

public class Breathing : Timerticket
{
public void breath()
{
}

public void breathing()
{
    Console.WriteLine("how long would you like to do this? (in seconds)");
    string st = Console.ReadLine();
    int timelimit = int.Parse(st);
    DateTime futere = endtime(timelimit);
    Console.Clear();

    do
    {
        Console.Write("Breath in...");
        countdownTimer(6);
        Console.WriteLine(" ");
        //Spinner();
        Console.Write("Breath out...");
        countdownTimer(8);
        Console.WriteLine(" ");
        //Spinner();
    }while(checktime(futere) == false);
    Console.WriteLine("Great Job!");
}
}