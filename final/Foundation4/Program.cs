using System;

class Program
{
    static void Main(string[] args)
    {
        // time is in minutes
        Running running = new Running(139 , 21);
        Stationary_Bicycles cycles = new Stationary_Bicycles(47, 19.456);
        Swimming swimming = new Swimming(30, 19);

        running.Display();
        cycles.Display();
        swimming.Display();
        
    }
}