using System;
using System.Net.Http.Headers;

class WritingAssignment : Assignment
{
    private string sTextbookSelection;
    private string sProblems;
    public void writingAssignment(string name, string topic, string selection, string problem)
    {
        sTextbookSelection = selection;
        sProblems = problem;
        Assinment(name, topic);
    }
    
    public string GetWritingInformation()
    {
        GetStudentName();
        return $"Name: {GetStudentName()} section: {sTextbookSelection} problem: {sProblems}";
    }
}