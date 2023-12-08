using System;

class Stationary_Bicycles : Activity
{


public Stationary_Bicycles(int time, double speed)
{
    _speed = speed;
    _time = time;

}


public override double Distance(int time, double speed)
    {
        return (speed * 60)/ time;
    }


    public override double Pace(int time, double speed)
    {
        return time / ((speed * 60)/ time);
    }


    public override void Display()
{
    Console.WriteLine($"{Date():MMMM/dd/yyyy} Cycling ({_time})minutes - Distance {Distance(_time, _speed):F3} Miles, Speed {_speed}, Pace: {Pace(_time,_speed):F3} minutes per Mile");
}
}