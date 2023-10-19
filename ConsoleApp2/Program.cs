using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread = new Thread(new ThreadStart(Worker));
        thread.Start();
        thread.Join();
    }

    static void Worker()
    {
        string[] a = {"a","b","c","d","e","f"};
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
        }
        foreach(string h in a)
        {
            Console.WriteLine(h);
            Thread.Sleep(500);
        }
    }
}
