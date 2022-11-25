
public class Customer : Person
{
    private string _deliveryAddress;
    public Customer(string FName, string LName, string DAddress) : base(FName, LName)
    {
        _deliveryAddress = DAddress;

    }

    public string DAddress { get; set; }

    public override void Print()
    {
        Console.Write("Delivery address: " + _deliveryAddress + " ");
        base.Print();
    }
}
