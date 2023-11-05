using System;

public class Listing : Timerticket
{
private List<string> listPrompt= new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?" , "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
public void listing()
{
}

private void DisplayRandomPrompt()
{
    Console.WriteLine(listPrompt[randomizer(listPrompt.Count)]);
}
private void CountDown()
{
    Console.Write("Get ready to start listing words...");
    Spinner();
    countdownTimer(8);
    Console.WriteLine("");
    Console.WriteLine("Begin!");
}
public void ListingAct()
{
    int uCount = 0;
    Console.WriteLine("how long would you like to do this? (in seconds)");
    string st = Console.ReadLine();
    int timelimit = int.Parse(st);
    DateTime futere = endtime(timelimit);
    Console.Clear();

    DisplayRandomPrompt();
    CountDown();

    while (checktime(futere) == false)
{
    string inp = Console.ReadLine();
    uCount++;
}

    Console.WriteLine($"You types {uCount} Items!");
}

}