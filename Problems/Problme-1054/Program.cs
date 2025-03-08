namespace Problem_1054;

internal class Program
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine($"1 {n} 1");
        }
    }
}
