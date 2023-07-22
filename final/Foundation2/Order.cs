public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = _products.Sum(p => p.GetTotalPrice());
        // If the customer lives in the USA, then the shipping cost is $5. 
        // If the customer does not live in the USA, then the shipping cost is $35.
        totalPrice += _customer.IsInUSA ? 5 : 35; 
        return totalPrice;
    }

    public string GetPackingLabel() => string.Join('\n', _products.Select(product => $"{product.Name} ({product.Id})"));

    public string GetShippingLabel() => $"Name: {_customer.Name}\nAddress: {_customer.Address}";
}