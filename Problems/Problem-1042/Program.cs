namespace Problem_1042;

internal class Program
{
    static void Main(string[] args)
    {
        var vals = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(vals[1] - 1 + vals[0] * 5);
    }
}
