using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("PACKING LABEL:");
        label.AppendLine("==============");

        foreach (Product product in _products)
        {
            label.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }

        return label.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("SHIPPING LABEL:");
        label.AppendLine("===============");
        label.AppendLine(_customer.GetName());
        label.AppendLine(_customer.GetAddress().GetFullAddress());

        return label.ToString();
    }
}
