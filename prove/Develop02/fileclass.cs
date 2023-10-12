using System;
using System.Net.Http.Headers;

public class Filecall
{ 
    public Filecall()
    {
    }


    public void Savefile(List<string> userText)
    {  //userText is not receving the user input.
        DateTime now = DateTime.Now;
        string filePath = $"{now.ToShortDateString()}";
        string result = string.Join(", ", userText);
        File.WriteAllText(filePath, result);
        Console.WriteLine($"Jounal entry has been saved to [{filePath}] ");
    }


    public void Returnfile(string userInput)
    {
        string fileContents = File.ReadAllText(userInput);
        Console.WriteLine($"Jounal entry {userInput}", fileContents);
        //Console.WriteLine(fileContents);
    }
}