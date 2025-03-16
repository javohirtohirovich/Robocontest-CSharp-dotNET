namespace Problem_0217;

internal class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        if (n < 9)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine((n - 9) / 10 + 1);
        }
    }
}
