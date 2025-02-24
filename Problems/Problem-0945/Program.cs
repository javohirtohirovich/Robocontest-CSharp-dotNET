namespace Problem_945;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
        Console.WriteLine(numbers[0] * numbers[1]);
    }
}
