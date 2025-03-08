using System.Numerics;

namespace Problem_0045;

internal class Program
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(n * (n + 1) / 2);
    }
}
