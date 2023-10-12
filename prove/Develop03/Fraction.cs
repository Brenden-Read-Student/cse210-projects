using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;

public class Fraction
 {
     private int _top;
     private int _bottom;
     public Fraction()
     {
        _top = 1;
        _bottom = 1;
     }
     public Fraction(int number)
     {
        _top = number;
        _bottom = 1;
     }
     public Fraction (int top, int bottom)
     {
        _top = top;
        _bottom = bottom;
     }
     public string Getfractionstring()
     {
        string outFraction = $"{_top}/{_bottom}";
        return outFraction; 
     }
     public double Getfractionvalue()
     {
        double value = _top/_bottom;
        return value; 
     }
 }
