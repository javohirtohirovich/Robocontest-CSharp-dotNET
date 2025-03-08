namespace Problem_0076;

internal class Program
{
    static void Main(string[] args)
    {
        var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var cost = int.Parse(Console.ReadLine());
        int sum = num.Sum();
        if (cost - sum > 0)
        {
            Console.WriteLine(cost - sum);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
