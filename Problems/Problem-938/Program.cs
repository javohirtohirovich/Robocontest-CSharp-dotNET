namespace Problem_938;

internal class Program
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        Console.WriteLine((10 * Math.Pow(3, 3) + 22 - 9 / 3) * 7 - 2022 - (a - 1));
    }
}
