namespace T2305M_CSharp.Session1;

public class Person
{
    // attribute - field
    private int id;
    private string name;
    private int age;
    private string address;

    public Person(int id, string name, int age, string address)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.address = address;
    }

    // property
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    // read-only property
    //public string Address => address;
    public string Address
    {
        get => address;
    }

    public void ShowInfo()
    {
        Console.WriteLine(id+"-"+name+"-"+age+"-"+address);
    }
}