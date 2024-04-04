using System;
using System.Linq.Expressions;
class Menu
{
    public static void MenuFunc()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos => 10s = 10 segundos.");
        Console.WriteLine("M = MInutos => 1m = 1 minuto.");
        Console.WriteLine("0 = Sair.");
        Console.Write("\nQuanto tempo deseja contar?: ");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;
        if (type == 'm')
        {
            multiplier = 60;
        }
        if (time == 0)
        {
            Finish.FinishFunc(); System.Environment.Exit(0);
        }
        PreStart.PreStartFunc(time * multiplier);
    }
}