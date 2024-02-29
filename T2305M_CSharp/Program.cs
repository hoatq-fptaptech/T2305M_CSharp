
using T2305M_CSharp.Session1;
// 
Person p = new Person();
p.Id = 1;
new Thread(() =>
{
    for (int i = 0; i < 20; i++)
    {
        try
        {
            lock (p)
            {
                p.Id = p.Id + 1;
                p.ShowInfo();
            }
            Thread.Sleep(1000);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}).Start();
new Thread(() =>
{
    for (int i = 0; i < 20; i++)
    {
        try
        {
            lock (p)
            {
                p.Id = p.Id + 1;
                p.ShowInfo();
            }
            Thread.Sleep(1000);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}).Start();

// async Task<int> DemoAsync()
// {
//     
// }