using System;
using System.ComponentModel.Design;
using System.Globalization;

public class Timerticket
{
    private List <char> spinner = new List<char>();
    public void Timertic()
    {
    }
    public void Spinner()
    {
        spinner.Add('|');
        spinner.Add('/');
        spinner.Add('-');
        spinner.Add('\\');
        spinner.Add('|');
        spinner.Add('/');
        spinner.Add('-');
        spinner.Add('\\');

        
        foreach (char s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(100);
            // this replaces the last number
            Console.Write("\b \b");
            //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }

    public void countdownTimer(int num)
    {
        for (int i = num; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int randomizer(int num)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, num);
        return randomNumber;
    }
    public DateTime endtime(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        return futureTime;
    }
    public bool checktime(DateTime futureTime)
    {
        DateTime currentTime = DateTime.Now;

        if (currentTime >= futureTime)
        {
            return true;
        }
        return false;
        
    }
}