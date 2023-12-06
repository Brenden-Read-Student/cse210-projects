using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectures1 = new Lectures("Martin Luther", 345);
        lectures1.SetVar("Thermal dynamics", "New discoverys and applications in the real feild", "December 12, 2024", "3:00 pm");
        Address address1 = new Address("USA", "New York", "New York", "3453 bullivard street");

        Receptions receptions1 = new Receptions("Thegreatestman@gmail.com");
        receptions1.SetVar("Wedding Reception", "The Queens wedding reception at the castle gardens will be decorated by us.","June 10, 2024", "4;45Pm");
        Address address2 = new Address("Europe", "Britan", "London", "6342 drewry lane");

        Outdoor outdoor1 = new Outdoor("Clear skys");
        outdoor1.SetVar("Futball", "Youth soccor day will be dependant on weather conditions and will need multiple feilds and balls", "April 24, 2025", "11;15Am - 6:45Pm");
        Address address3 = new Address("USA", "Idaho", "Boise", "3549 sleepy drive");



        lectures1.Display();
        address1.Display();
        Console.WriteLine(" ");
        receptions1.Display();
        address2.Display();
        Console.WriteLine(" ");
        outdoor1.Display();
        address3.Display();
    }
}