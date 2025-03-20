using System.Numerics;

namespace Problem_0229;

internal class Program
{
    static void Main()
    {
        var arrNums = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

        var arifmeticMean = (double)(arrNums[0] + arrNums[1]) / 2.0;
        var geometricMean = Math.Sqrt((double)(arrNums[0] * arrNums[1]));

        if (arifmeticMean > geometricMean)
        {
            Console.WriteLine(">");
        }
        else if (arifmeticMean < geometricMean)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("=");
        }
    }
}
