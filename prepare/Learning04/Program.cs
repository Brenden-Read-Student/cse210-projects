using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
//assignment
        Console.WriteLine("What is your name?");
        string mName = Console.ReadLine();
        Console.WriteLine("What is your topic?");
        string mTopic = Console.ReadLine();
        Assignment Assignment = new Assignment();
        Assignment.Assinment(mName, mTopic);
        Console.WriteLine(Assignment.GetSummary());
//Math assignment
        Console.WriteLine("What is your section?");
        string mSection = Console.ReadLine();
        Console.WriteLine("What is your problem?");
        string mProblme = Console.ReadLine();
        MathAssignment MathAssignment = new MathAssignment();
        MathAssignment.Math(mName, mTopic, mSection, mProblme);
        Console.WriteLine(MathAssignment.GetSummary());
        Console.WriteLine(MathAssignment.GetHomeworkList());
//WritingAssignment
        WritingAssignment WritingAssignment = new WritingAssignment();
        WritingAssignment.writingAssignment(mName, mTopic, mSection, mProblme);
        Console.WriteLine(WritingAssignment.GetWritingInformation());

    }
}