using System;
using System.Net.Http.Headers;

  
public class Scriptverse
{
private string ScriptversePath;

public string scripstring(int num)
{
    List<string> scripture = new List<string>(); 
    scripture[0] = "So why do you worry about clothing? Consider the lilies of the field, how they grow: they neither toil nor spin; and yet I say to you that even Solomon in all his glory was not arrayed like one of these";
    scripture[1] = "Blessed are the meek, for they shall inherit the earth.";
    scripture[2] = "";
    scripture[3] = "";
    return scripture[num];
}  

static Scriptverse()
{

}
}