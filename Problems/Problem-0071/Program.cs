namespace Problem_0071;

internal class Program
{
    static void Main(string[] args)
    {
        long a = long.Parse(Console.ReadLine()!);
        if (a == 0) { Console.WriteLine(1); }
        else { Console.WriteLine(a / 2 + 1); }
    }
}
