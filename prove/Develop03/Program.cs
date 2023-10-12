using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("choose a whole number");
        string con = Console.ReadLine();
        Console.WriteLine("again");
        string son = Console.ReadLine();
        int a = int.Parse(con);
        int b = int.Parse(son);

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.Getfractionstring());
        Console.WriteLine(f1.Getfractionvalue());

        Fraction f2 = new Fraction(a);
        Console.WriteLine(f2.Getfractionstring());
        Console.WriteLine(f2.Getfractionvalue());

        Fraction f3 = new Fraction(a,b);
        Console.WriteLine(f3.Getfractionstring());
        Console.WriteLine(f3.Getfractionvalue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.Getfractionstring());
        Console.WriteLine(f4.Getfractionvalue());
    }
}