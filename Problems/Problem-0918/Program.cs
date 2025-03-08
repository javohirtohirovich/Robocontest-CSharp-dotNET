namespace Problem_0918;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        if (n % k == 0)
        {
            Console.WriteLine(n / k);
        }
        else
        {
            Console.WriteLine(n / k + 1);
        }
    }
}
