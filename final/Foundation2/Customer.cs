public class Customer
{
    private string _name;
    private Address _address;

    public string Name => _name;
	public string Address => _address.ToString();
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA => _address.IsInUSA;
}