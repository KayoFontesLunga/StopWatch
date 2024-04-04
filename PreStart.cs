using System;
using System.Threading;
class PreStart
{
    public static void PreStartFunc(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready....");
        Thread.Sleep(1000);
        Console.WriteLine("Set....");
        Thread.Sleep(1000);
        Console.WriteLine("Go!!!");
        Thread.Sleep(2500);
        Start.StartFunc(time);
    }
}