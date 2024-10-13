using System;

class Product
{
    private string name;
    private string productId;
    private decimal pricePerUnit;
    private int quantity;

    public Product(string name, string productId, int pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public string Name { get { return name; } }
    public string ProductId { get { return productId; } }
    public decimal PricePerUnit { get { return pricePerUnit; } }
    public int Quantity { get { return quantity; } }

    public decimal CalculateTotalCost()
    {
        return pricePerUnit * quantity;
    }
}