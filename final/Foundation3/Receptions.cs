using System;

class Receptions : Event
{


    public Receptions(string Email)
    {
         _type = "Reception";
         //_description = "Come join us for a wonderful outside event at our Reception center in Utah for the most specatulat after wedding party oyu have imagined.";
         _email = Email;
    }
}