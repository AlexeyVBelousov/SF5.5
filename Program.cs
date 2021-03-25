using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введи число!");
        var num = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}! = {1}", num, Factorial(num));

        Console.ReadKey();
    }

    static decimal Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }
}