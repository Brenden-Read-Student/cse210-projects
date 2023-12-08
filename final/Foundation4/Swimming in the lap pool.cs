using System;

class Swimming : Activity
{
    public Swimming(int time, double laps)
    {
        _laps = laps;
        _time = time;
    }

    public override double Distance(int time, double laps)
    {
        return base.Distance(time, laps);
    }


    public override double Speed(int time, double distance)
    {
        return base.Speed(time, distance);
    }

    public override double Pace(int time, double laps)
    {
        return time / Distance(time, laps);
    }


    public override void Display()
    {
        Console.WriteLine($"{Date():MMMM/dd/yyyy} Swimming ({_time})minutes - # of Laps ({_laps}), Distance ({Distance(_time, _laps):F3}) Miles, Speed {Speed(_time,Distance(_time, _laps)):F3}, Pace: {Pace(_time, _laps):F3} minutes per Mile");
    }
}