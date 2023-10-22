using System;
using System.Net.Http.Headers;

  
public class Scriptverse
{
//private string ScriptversePath;

public string scripstring(int num)
{
    List<string> scripture = new List<string>{"So why do you worry about clothing? Consider the lilies of the field, how they grow: they neither toil nor spin; and yet I say to you that even Solomon in all his glory was not arrayed like one of these.","Nevertheless, Jacob, my first-born in the wilderness, thou knowest the greatness of God; and he shall consecrate thine afflictions for thy gain.","And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.",""}; 
    //scripture[3] = "";
    //scripture[4] = "";
    return scripture[num];
}  
public List<string> Lineconvert(string scripture)
    {
        string[] words = scripture.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> scriptList = new List<string>(words);
        return scriptList;
    }
}