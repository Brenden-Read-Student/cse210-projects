using System;

class Address
{
    private string _streetAddress{get; set; }
    private string _city{get; set; }
    private string _state{get; set; }
    private string _country{get; set; }


    public void SettheAddress(string City, string State,string country, string myAdress)
    {
        _streetAddress = myAdress;
        _city = City;
        _state = State;
        _country = country;
    }
    public string GetAddress()
    {
        string realAddress = _streetAddress+" "+_city+ " " +_state + " " +_country;
        return realAddress;
    }

    

    public int GetCountry()
    {
        if (_country == "USA")
        {
            return 1;
        }
        else if (_country == "usa")
        {
            return 1;
        }
        else if (_country == "United States")
        {
            return 1;
        }
        else if (_country == "United States of America")
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}