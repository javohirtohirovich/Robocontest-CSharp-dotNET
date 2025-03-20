namespace Problem_0511;

internal class Program
{
    static void Main(string[] args)
    {
        var num = Console.ReadLine();
        var sum = 0;
        foreach (var digit in num)
        {
            if (char.IsDigit(digit))
            {
                sum += digit - '0';
            }
        }
        Console.WriteLine(sum);
    }
}
