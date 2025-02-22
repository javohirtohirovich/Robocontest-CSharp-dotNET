namespace Problem_1103;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine((numbers[1] - numbers[0] + 1) * 10);
    }
}
