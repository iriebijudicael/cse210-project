using System;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label";
        foreach (Product product in products)
        {
            label += $"{product.Name} ({product.ProductId})";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "\nShipping Label";
        label += $"\n{customer.Name}";
        label += $"\n{customer.Address}";
        return label;
    }
}