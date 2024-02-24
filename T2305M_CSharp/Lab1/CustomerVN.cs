namespace T2305M_CSharp.Lab1;

public class CustomerVN : Customer
{
    private string type;

    public CustomerVN(int id, string name, DateTime invoiceAt, int qty, string type) : base(id, name, invoiceAt, qty)
    {
        this.type = type;
    }

    public string Type
    {
        get => type;
        set => type = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override long Subtotal()
    {
        if (Qty < 50)
            return Qty * 1000;
        else if (Qty < 100)
            return Qty * 1200;
        else if (Qty < 200)
            return Qty * 1500;
        else
            return base.Subtotal();
    }
}