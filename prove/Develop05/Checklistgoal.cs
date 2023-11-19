using System;
class Checklistgoal : Goal
{
    public void checklist()
    {
    }

    
    public override void GetValues()
    {
        Console.Write("What do you want to name your goal?: ");
        string goalName = Console.ReadLine();
        Console.Write("Write a description of your goal: ");
        string goalDescription = Console.ReadLine();
        Console.Write("What are the points for achiving the entire goal? ");
        string goalPoints = Console.ReadLine();
        Console.Write("What are the points for achiving the part of your goal? ");
        string goalBonusPoints = Console.ReadLine();
    }
}