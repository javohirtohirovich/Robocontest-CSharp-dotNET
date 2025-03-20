namespace Problem_0265;

internal class Program
{
    static void Main(string[] args)
    {
        var arrNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(arrNums[0] * arrNums[1]);
    }
}
