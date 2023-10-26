using System;
using System.Net.Http.Headers;

class MathAssignment : Assignment
{
    private string sTextbookSelection;
    private string sProblems;
    public void Math(string name, string topic, string textbook, string problem)
    {
        sTextbookSelection = textbook;
        sProblems = problem;
        Assinment(name, topic);
    }

    public string GetHomeworkList()
    {
        return $"section: {sTextbookSelection} problem: {sProblems}";
    }

}