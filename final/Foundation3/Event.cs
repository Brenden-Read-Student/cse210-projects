using System;

class Event 
{
public int _capacityCount;
public string _email;
public string _weather;
public string _description;
public string _type;
public string _speaker;
private string _title;
private string _date;
private string _time;


public void SetVar(string title, string description, string date, string time)
{
    _title = title;
    _description = description;
    _date = date;
    _time = time;
}


public void Display()
{
    Console.WriteLine("What would you like to know about this event?");
    Console.WriteLine("1. Standard details");
    Console.WriteLine("2. Full details");
    Console.WriteLine("3. Short description");
    string userIn = Console.ReadLine();
    if (userIn == "1")
    {
        // give standard method
        Console.WriteLine(_title);
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
    }


    else if (userIn == "2")
    {
        //give full description
        Console.WriteLine(_type);
        Console.WriteLine(_title);
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        if (_type == "Lecture")
        {
            Console.WriteLine($"speaker : {_speaker}");
            Console.WriteLine($"Capacity : {_capacityCount} seats");
        }
        else if (_type == "Reception")
        {
            Console.WriteLine($"Email: {_email}");
        }
        else if (_type == "Outdoor Gathering")
        {
            Console.WriteLine($"Weather: {_weather}");
        }
        else
        {
            Console.WriteLine("ERROR: Unknown type");
        }
    }
    

    else
    {
        //give shord description
        Console.WriteLine(_type);
        Console.WriteLine(_title);
        Console.WriteLine($"Date: {_date}");
    }
}
}