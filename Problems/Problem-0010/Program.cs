namespace Problem_10;

internal class Program
{
    static void Main(string[] args)
    {
        var n = long.Parse(Console.ReadLine());
        var moneyArray = Console.ReadLine().Split().Select(long.Parse).ToArray();

        if (moneyArray.Sum() >= n)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
