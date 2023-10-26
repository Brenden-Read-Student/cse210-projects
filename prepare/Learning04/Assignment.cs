using System;
using System.Net.Http.Headers;

class Assignment
{
    private string sName;
    private string sTopic;
    public void Assinment(string name, string topic)
    {
        sName = name;
        sTopic = topic;
    }

    public string GetSummary()
    {
        return $"Name:{sName} Topic:{sTopic}";
    }
    public string GetStudentName()
    {
        return sName;
    }
}