using System;

class Program
{
    static void Main(string[] args)
    {
        //get rid of this variable
        int _totalScore = 0;
        //

        int Key = 0;
        //Public int TotalScore = 0;
        //double TotalScore = 0;
        do
        {
            Console.WriteLine($"Your Total Score: {_totalScore}");
            Console.WriteLine($" ");
            string userInput = Menu();
            if (userInput == "1")
            {
                //Create new goal class
                Goal goal1 = new Goal();
                goal1.goalSmallMenu();
            }
            else if (userInput == "2")
            {
                //call recording cass
            }
            else if (userInput == "3")
            {
                Recording recording = new Recording();
                recording.SaveData();
            }
            else if (userInput == "4")
            {
                Recording rec = new Recording();
                rec.retrieveData();
            }
            else if (userInput == "5")
            {
                //
            }
            else if (userInput == "6")
            {
            Key = 10;   
            }
            else 
            {
                Console.WriteLine("That was not in the menu. Please try one of the numbers from the menu.");
            }
        }while(Key !=10);

    }

    
    static string Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal ");
        Console.WriteLine("2. List Goals ");
        Console.WriteLine("3. Save Goals ");
        Console.WriteLine("4. Load Goals ");
        Console.WriteLine("5. Record Goals ");
        Console.WriteLine("6. Quit ");
        Console.Write("Select a choice from the menu:  ");
        string userInput = Console.ReadLine();
        return userInput;

    }
}