namespace Problem_0119;

internal class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        if (n % 4 == 0)
        {
            Console.WriteLine(n / 2);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}
