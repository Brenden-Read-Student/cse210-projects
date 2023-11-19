using System;

class Recording : Goal
{
    private string _filePath;
    public string _curentscore;
    public void recording ()
    {
    }


    private void UserPath()
    {
        Console.WriteLine("What is the Name of this save file?");
        _filePath = Console.ReadLine();
    }



    public void SaveData()
    {
        UserPath();
        using (StreamWriter writer = File.AppendText(_filePath))
        foreach (Goal input in _goalList)
            {
                writer.WriteLine(input);
            }
        Console.WriteLine($"User inputs have been saved to {_filePath}");
    }


    public List<Goal> retrieveData()
    {
        UserPath();
        List<Goal> retrievedInputs = new List<Goal>();
        if (File.Exists(_filePath))
        {
            Console.WriteLine($"Contents of {_filePath}:");
            
            // Read and display each line from the file
            using (StreamReader reader = File.OpenText(_filePath))
            {
                Goal line;
                while ((line = reader.ReadLine()) != null)
                {
                    retrievedInputs.Add(line);
                }
            }
        }
        else
        {
            Console.WriteLine($"File {_filePath} does not exist.");
        }
        return retrievedInputs;
    }








}