using System;
using System.Globalization;

class Lectures : Event
{


    public Lectures(string speaker, int chairCount)
    {
        _type = "Lecture";
        //_description = "This lecture will be on the laws and new findings of thermal dynamics and how they can be aplyed today.";
        _speaker = speaker;
        _capacityCount = chairCount;
    }
}