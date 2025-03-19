namespace Problem_0293;

internal class Program
{
    static void Main(string[] args)
    {
        var str = Console.ReadLine();
        Console.WriteLine(str.Length);
        foreach (var c in str)
        {
            string encryption = DecimalToBinary((int)c);
            Console.WriteLine(encryption);
        }
    }

    public static string DecimalToBinary(int number)
    {
        string binnary = "";
        while (number > 0)
        {
            binnary = (number % 2) + binnary;
            number = number / 2;
        }

        return binnary;
    }
}
