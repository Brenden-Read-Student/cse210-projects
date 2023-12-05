using System;
class Product
{
    private string _name {get; set;}
    private int _productId {get; set;}
    private double _price {get; set;}
    private int _quantity {get; set;}


    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    

    public double TotalPrice()
    {
        double totalPrice = _price * _quantity;
        return totalPrice;
    }
}