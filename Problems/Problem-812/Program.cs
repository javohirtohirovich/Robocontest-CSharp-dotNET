namespace Problem_812;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        Console.WriteLine(int.Parse(input[^1].ToString())%2);
    }
}
