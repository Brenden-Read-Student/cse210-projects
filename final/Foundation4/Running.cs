using System;

class Running : Activity
{


public Running(int time, double distance)
{
    _distance = distance;
    _time = time;
}

public override double Speed(int time, double distance)
{
    return base.Speed(time, distance);
}


public override double Pace(int time, double distance)
{
    return base.Pace(time, distance);
}


    public override void Display()
{
    Console.WriteLine($"{Date():MMMM/dd/yyyy} Running ({_time})minutes - Distance {_distance} Miles, Speed {Speed(_time,_distance):F3}, Pace: {Pace(_time,_distance):F3} minutes per Mile");
}
}