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

    public void AddProduct(Product product) =>
        _products.Add(product);

    public Customer Customer => _customer;
    public IReadOnlyList<Product> Products => _products.AsReadOnly();

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        var builder = new StringBuilder();
        builder.AppendLine("Packing Label:");
        foreach (var product in _products)
        {
            builder.AppendLine($"{product.Name} (ID: {product.ProductId})");
        }
        return builder.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        var builder = new StringBuilder();
        builder.AppendLine("Shipping Label:");
        builder.AppendLine(_customer.Name);
        builder.Append(_customer.Address.GetAddressString());
        return builder.ToString();
    }
}
