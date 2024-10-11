//Customer Class
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }
    public string GetName()
    {
        return name;
    }

    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    public string GetAddress()
    {
        return address.GetFullAddress();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}