namespace T2305M_CSharp.Session3;

public delegate void PrintMessage(string msg);

public class DemoDelegate
{
    public void ShowInfo(string s)
    {
        Console.WriteLine("Show info: "+s);
    }
}