using System;
using System.Net.Http.Headers;

public class Refrencecall
{
    private string Refrence;
    public string scripstring(int num)
{
    List<string> refer = new List<string>(); 
    refer[0] = "Matthew 6:28";
    refer[1] = "Matthew 5:5";
    refer[2] = "";
    refer[3] = "";
    return refer[num];
}
    public Refrencecall()
    {

    }
    public Refrencecall(int num)
    {

    }
}