using System;

class Activity
{
public double _laps;
public int _time;
public double _distance;
public double _speed;

public DateTime Date()
{
    return DateTime.Today;
}


public virtual double Distance(int time, double laps)
{
    return _laps * 50 / 1000 * 0.62;
}

public virtual double Speed(int time, double distance)
{
    return distance/time;
}
public virtual double Pace(int time, double distance)
{
    return time/distance;
}


public virtual void Display()
{
    // Not Done yet
    Console.WriteLine($"{Date():MMMM/dd/yyyy} Swimming ({_time}) - # of Laps {_distance * 1000 / 31} Miles, Speed {Speed(_time,_distance)}, Pace: {Pace(_time,_distance)} minutes per Mile");
}
}