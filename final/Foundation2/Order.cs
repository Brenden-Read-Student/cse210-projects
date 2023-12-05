using System;
using System.Security;

class Order
{
    private List<string> _products = new List<string>();
    private List<int> _productsId = new List<int>();
    private string _costumer;
    private double _totalPrice = 0;
    private string _addressFind;

    public Order(string city, string state,string myCountry, string Address)
    {
        // shiping cost
         //address.SettheAddress(city, state, myCountry, Address);
        Customer com1 = new Customer();
        string country = com1.WhereLive(city, state, myCountry, Address);
        _addressFind = com1.GetAddress();
        if (country == "USA")
        {
            _totalPrice += 5;
        }
        else
        {
            _totalPrice += 35;
        }
    }
    

    public void SetCostumer(string name)
    {
        _costumer = name;
    }



    public void ItemCost(string product, int Id, double price, int quantity)
    {
        Product cost = new Product(product, Id, price,quantity);
        _totalPrice += cost.TotalPrice();  
        _products.Add(product);
        _productsId.Add(Id);
              
    }



    public void Display()
    {
        Console.WriteLine("The packing label:");

        // Check if both lists have the same number of elements
        if (_products.Count != _productsId.Count)
        {
            Console.WriteLine("Error: The number of elements in the lists does not match.");
            return;
        }

        // Use foreach to iterate through the lists simultaneously
        int index = 0;
        foreach (var (product, productId) in _products.Zip(_productsId, (p, id) => (p, id)))
        {
            Console.WriteLine($" {product}, {productId}");
            index++;
        }
        Console.WriteLine($"Shipping Lable:");
        Console.WriteLine($" {_costumer}, (Address) {_addressFind}");
        Console.WriteLine($"Total Price:");
        Console.WriteLine($" {_totalPrice.ToString("F2")}$");
    }
    
}