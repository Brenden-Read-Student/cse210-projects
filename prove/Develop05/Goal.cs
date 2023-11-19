using System;
class Goal
{
    private int _totalScore = 0;
    private string _goalName {get; set;}
    private string _goalDescription {get; set;}
    private int _pointsValues {get; set;}
    public static List<Goal> _goalList = new List<Goal>();
    // private int _bonusPoints;
    // private int _bonusCounter;

    public void goalSmallMenu()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("1. Create a Simple Goal");
        Console.WriteLine("2. Create an Eternal Goal");
        Console.WriteLine("3. Create a Checklist Goal");
        Console.WriteLine("--------------------------");
        string userInputTwo = Console.ReadLine();
        if(userInputTwo == "1")
        {
            Simplegoal simplegoal = new Simplegoal();
            simplegoal.GetValues();
            _goalList.Add(simplegoal);
        }
        else if (userInputTwo == "2")
        {
            Eternalgoal eternalgoal = new Eternalgoal();
            eternalgoal.GetValues();
            _goalList.Add(eternalgoal);
        }
        else if (userInputTwo == "3")
        {
            Checklistgoal checklistgoal = new Checklistgoal();
            checklistgoal.GetValues();
            _goalList.Add(checklistgoal);
        }
        else
        {
            Console.WriteLine("That was not an option please try again.");
        }
    }


    
    public virtual void GetValues()
    {
        //grab goal from user
        Console.Write("What do you want to name your goal?: ");
        string goalName = Console.ReadLine();
        Console.Write("Write a description of your goal: ");
        string goalDescription = Console.ReadLine();
        Console.Write("What are the points for achiving this goal? ");
        string goalPoints = Console.ReadLine();
    }


}