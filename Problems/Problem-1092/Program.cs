namespace Problem_1092;

internal class Program
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine()!);
        if (n % 2 == 0) { Console.WriteLine(n); }
        else { Console.WriteLine(n * 2); }
    }
}
