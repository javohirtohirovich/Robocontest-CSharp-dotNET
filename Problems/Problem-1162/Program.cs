namespace Problem_1162;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine((n / 2 + 1) * (n - n / 2 + 1));
    }
}
