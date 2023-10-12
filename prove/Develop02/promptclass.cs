using System;
using System.Net.Http.Headers;

public class PromptsService
{
    public string journal = "";
    public string globaljournal = "";
    public PromptsService()
    {
    }
    public List<string> Backround()
    {
        
        string[] str = new string[5];
        str[0] = "What was the first thing your thought of when you woke up today?";
        str[1] = "What was your daily epiphany?";
        str[2] = "Who did you kill today?";
        str[3] = "what was the bigest let down today?";
        str[4] = "WHo do you love?";


        Random random = new Random();
        int randomNumber = random.Next(0, 4); 
        Console.WriteLine(str[randomNumber]);
        string jaurnal = Console.ReadLine();
        List<string> journalarray = new List<string>();


        for (int i = 0; i <= 10; i++ )
        {
        Console.WriteLine("Are you sure you are done?");
        string nuint = Console.ReadLine();
        if (nuint == "yes")
        {
            break;
        }
        else if (nuint == "no")
        {
            journalarray.Add(Console.ReadLine());
        }
        }
        return journalarray;
    }
    public List<string> Displayprompt()
    {
        List<string> journal = Backround();
        List<string>globaljournal = journal;
        return globaljournal;
    }
    public void Displayresponse()
    {
        Console.WriteLine(globaljournal);
    }
}