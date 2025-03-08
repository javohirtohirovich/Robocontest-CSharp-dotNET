using System;

namespace Problem_0789;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n < 5)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(1);
        }
    }
}
