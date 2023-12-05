using System;
class Customer 
{
    private string _name{get; set;}
    private string _address{get; set;}


    public string GetAddress()
    {
        return _address;
    }

    public string WhereLive(string City, string State,string mwcountry, string myAdress)
    {
        Address address = new Address();
        address.SettheAddress(City, State,mwcountry, myAdress);
        int country = address.GetCountry();
        _address = address.GetAddress();
        if (country ==  1)
        {
            return "USA";
        }
        else
        {
            return "other";
        }
    }
}