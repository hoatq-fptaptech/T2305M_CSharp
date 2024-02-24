namespace T2305M_CSharp.Lab1;

public class CustomerNN : Customer
{
    private string country;

    public CustomerNN(int id, string name, DateTime invoiceAt, int qty, string country) : base(id, name, invoiceAt, qty)
    {
        this.country = country;
    }

    public string Country
    {
        get => country;
        set => country = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override long Subtotal()
    {
        return base.Subtotal();
    }
}