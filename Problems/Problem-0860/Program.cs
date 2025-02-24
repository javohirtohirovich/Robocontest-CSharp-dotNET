namespace Problem_860;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(input[1]+1 - input[0]);
    }
}
