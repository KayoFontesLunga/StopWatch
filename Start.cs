using System;
using System.Threading;

class Start
{
    public static void StartFunc(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime += 1;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("StopWatch finish!!!");
        Thread.Sleep(2500);
        Menu.MenuFunc();
    }
}