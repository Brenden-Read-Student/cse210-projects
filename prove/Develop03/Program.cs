using System;
using System.Net.Http.Headers;

public class Program
{
static int randomizer()
{
    Random random = new Random();
    int randomNumber = random.Next(0, 3);
    return randomNumber;
}
static void Main()
{
    int ran = randomizer();

    Refrencecall Refrencecall = new Refrencecall();
    Console.WriteLine(Refrencecall.scripstring(ran));

    Scriptverse Scriptverse = new Scriptverse();
    Console.WriteLine(Scriptverse.scripstring(ran));
    Console.ReadLine();

    Scriptmix Scriptmix = new Scriptmix();
    Scriptmix.Userinteract(ran);
    
}

}