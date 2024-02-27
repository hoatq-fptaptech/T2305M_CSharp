using T2305M_CSharp.Session3;
static void DisplayHello(string str)
{
    Console.WriteLine("Hello: "+str);
}
DemoDelegate dd = new DemoDelegate();

PrintMessage pm = new PrintMessage(DisplayHello);
pm += dd.ShowInfo;
pm += new DemoDelegate().ShowInfo;
pm("Nguyen Van An");

Button login = new Button("Login",DisplayHello);