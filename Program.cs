using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введи число!");
        var num = int.Parse(Console.ReadLine());
        Console.WriteLine("Введи степень!");
        var pow = byte.Parse(Console.ReadLine());

        Console.WriteLine("{0}^{1} = {2}", num, pow, PowerUp(num, pow));

        Console.ReadKey();
    }

    private static decimal PowerUp(int N, byte pow)
    {
        if (pow == 0)
        {
            return 1;
        }
        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }
    }
}