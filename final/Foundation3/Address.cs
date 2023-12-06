using System;

class Address
{

private string _country;
private string _state;
private string _city;
private string _streetAddress;

    public Address(string country, string state, string city, string address)
    {
        _country = country;
        _state = state;
        _city = city;
        _streetAddress = address;
    }
    public void Display()
    {
        Console.WriteLine("Address: " + _streetAddress + " " + _country + " " + _state + " " + _city);
    }
}