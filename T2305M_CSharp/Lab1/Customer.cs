namespace T2305M_CSharp.Lab1;

public class Customer
{
    private int id;
    private string name;
    private DateTime invoiceAt;
    private int qty;

    public Customer(int id, string name, DateTime invoiceAt, int qty)
    {
        this.id = id;
        this.name = name;
        this.invoiceAt = invoiceAt;
        this.qty = qty;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateTime InvoiceAt
    {
        get => invoiceAt;
        set => invoiceAt = value;
    }

    public int Qty
    {
        get => qty;
        set => qty = value;
    }

    public virtual long Subtotal()
    {
        return Qty * 2000;
    }
}