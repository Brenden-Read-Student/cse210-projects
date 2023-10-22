using System;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        List<string> gjournal;
        int funVariable = 0;
        Console.WriteLine("Welcome to your journal");
        Console.WriteLine("What would tou like to do?");
        do
        {
        Console.WriteLine("1. Start new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Quit");
        string userInpit = Console.ReadLine();
        int userInput = int.Parse(userInpit);
        if (userInput == 1)
        {
            PromptsService promptService =  new PromptsService();
            //journal = promptService.journal = "";


            //problem retrieving user text from class.
            List<string> journal = promptService.Displayprompt();
            gjournal = journal;
            //promptService.Displayprompt();

            //string journal = Console.ReadLine();

        }
        else if (userInput == 2)
        {
            //display journal function
            PromptsService promptService =  new PromptsService();
            promptService.globaljournal = "";
            promptService.Displayresponse();
        }
        else if (userInput == 3)
        {
            //save journal
            Filecall filecall = new Filecall();
            //filecall.jounal = "";
           // filecall.Savefile(gjournal);
        }
        else if (userInput == 4)
        {
            //load journal
            Console.WriteLine("What is te date of the jounal you wish to read?");
            string fileName = Console.ReadLine();

            Filecall filecall = new Filecall();
            filecall.Returnfile(fileName);
        }
        else if (userInput == 5)
        {
            funVariable = 5;
        }
        else
        {
            Console.WriteLine("Not a Number. please try again");
        }
        }while(funVariable != 5);
    }
}

