namespace Problem_0053;

internal class Program
{
    static void Main(string[] args)
    {
        var n = long.Parse(Console.ReadLine()!);
        if(n>3)
        {
            Console.WriteLine(n * (n - 3) / 2);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
