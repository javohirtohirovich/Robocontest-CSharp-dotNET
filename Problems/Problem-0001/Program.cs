namespace Problem_1;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        Console.WriteLine(input[0] + input[1]);
    }
}
