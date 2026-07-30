public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    private const double DomesticShippingCost = 5.0;
    private const double InternationalShippingCost = 35.0;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? DomesticShippingCost : InternationalShippingCost;
        total += shippingCost;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (Product ID: {product.GetProductId()})\n";
        }

        return label.TrimEnd('\n');
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetDisplayText()}";
    }
}