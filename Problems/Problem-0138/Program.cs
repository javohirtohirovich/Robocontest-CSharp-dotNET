namespace Problem_0138;

internal class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow(n, 5) + 8 * Math.Pow(n, 4) - 5 * Math.Pow(n, 3) + 3 * Math.Pow(n, 2) + n - 12);
    }
}
