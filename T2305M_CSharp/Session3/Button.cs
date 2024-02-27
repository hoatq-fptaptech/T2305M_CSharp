namespace T2305M_CSharp.Session3;

public class Button
{
    public event PrintMessage Click;

    public string text;
    
    public Button(string text, PrintMessage action)
    {
        this.text = text;
        Click = action;
    }

    public void ClickAction(string ss)
    { 
        //...
    }
}