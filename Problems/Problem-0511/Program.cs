namespace Problem_0511;

internal class Program
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        long n = long.Parse(a);
        if (n >= -9)
        {
            Console.WriteLine(n);
        }
        else
        {
            long v = long.Parse(a.Substring(0, 2));
            long g = long.Parse(a.Substring(2));
            Console.WriteLine(v + g);
        }
    }
}
