using System;
//using System.Reflection;
//using System.Reflection.Metadata;

public class Relflection : Timerticket
{
private List <string> array1 = new List<string>{"Think of a time when you stood up for someone else. ","Think of a time when you did something really difficult. ","Think of a time when you helped someone in need. ","Think of a time when you did something truly selfless. "};
private List <string> array2 = new List<string>{"Why was this experience meaningful to you? ","Have you ever done anything like this before? ","How did you get started? ","How did you feel when it was complete? ","What made this time different than other times when you were not as successful? ","What is your favorite thing about this experience? ","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience? ","How can you keep this experience in mind in the future? "};
private List <int> remember = new List<int>();
private int where;
private DateTime futre_Time;

public void reflect()
{
}

private void printquestion()
{
    Console.WriteLine(array1[randomizer(array1.Count)]);
}
private void printfollowquestion()
{
    //List <int> remember = new List<int>();
    //int where;
    int key = 0;
    do{
        where = randomizer(array2.Count);
        string prin = array2[where];
            //if mayhem
            if (remember.Contains(where) == false)
            {
                Console.WriteLine(prin);
                key += 3;
            }
            if (array2.Count == remember.Count+1)
            {
                Console.WriteLine("There are No more Questions to ask you");
                key += 6;
            }
        remember.Add(where);

    }while(key == 0);
}
private void secondquestion()
{
    Console.WriteLine("now reflect on this question");
    Console.WriteLine(" ");
    printfollowquestion();
    Spinner();
    Console.ReadLine();

    do{
        Spinner();
        Console.WriteLine("     ");
        printfollowquestion();
        Console.ReadLine();
    }while(checktime(futre_Time) == false);

    Console.WriteLine("Great Job!");
}


public void reflections()
{
    Console.WriteLine("how long would you like to do this? (in seconds)");
    string st = Console.ReadLine();
    int timelimit = int.Parse(st);
    DateTime futere = endtime(timelimit);
    futre_Time = futere;
    Console.Clear();

    printquestion();
    Console.Write("Ponder this question for a few seconds...");
    Spinner();
    Spinner();
    Spinner();
    Spinner();
    //Spinner();
    Console.WriteLine("");
    Console.WriteLine("Now write what you feel");
    Console.ReadLine();

    secondquestion();
        
    
    
}

}