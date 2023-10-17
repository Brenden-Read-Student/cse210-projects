using System;
using System.Net.Http.Headers;

public class Main 
{
static int randomizer()
{
    Random random = new Random();
    int randomNumber = random.Next(0, 1);
    return randomNumber;
}
static Main()
{
    int ran = randomizer();

    Refrencecall Refrencecall = new Refrencecall();
    Console.WriteLine(Refrencecall.scripstring(ran));

    Scriptverse Scriptverse = new Scriptverse();
    Console.WriteLine(Scriptverse.scripstring(ran));
}

}