using System;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
public class Scriptmix
{
    private List<string> scripture;
    private int check = 0;
    private int randomizer(int num)
{
    Random random = new Random();
    int randomNumber = random.Next(0, num);
    return randomNumber;
}
    private void Hideword()
    {
        int end = 0;
        string line = "___";
        int l = scripture.Count;
        int rand = randomizer(l);
        do {
            //start
            foreach (string word in scripture)
                {
                    if (word.Contains(line))
                    {
                        end += 1;
                    }
                }
            if (end == scripture.Count)
            {
                check = 1;
                break;
            }
            //stop

            l = scripture.Count;
            rand = randomizer(l);
        }while (scripture[rand] == "_____");
        if (scripture[rand] == "_____")
        {
        }
        else
        {
        Console.WriteLine($"removed word is {scripture[rand]}");
        //scripture.RemoveAt(rand);
        scripture[rand] = "_____"; 
        }
       
    }
    public void Userinteract(int snun) 
    {
    Scriptverse Scriptverse = new Scriptverse();
    scripture = Scriptverse.Lineconvert(Scriptverse.scripstring(snun));
    
    do
    {
    // Console.Clear();
    Console.WriteLine("do you want to keep playing?");
    // Console.WriteLine("do you want to keep playing?");
    string user =Console.ReadLine();
    if (user == "quit")
    {
        Console.WriteLine("Good Job!");
        break; 
    }
    else if (user == "Quit")
    {
        Console.WriteLine("Good Job!");
        break; 
    }
    else 
    {
        if (check == 1)
        {
            Console.WriteLine("Congratulations Good job!!");
            break;
        }
        for(int i = 0; i<3; i++)
        {
            Hideword();
        }
    }
    Console.Clear();
    foreach (string word in scripture)
            {
                Console.Write($"{word} ");
            }
    Console.WriteLine(" ");
    Console.WriteLine("do you want to keep playing?");
    }while (true);       
    }

}