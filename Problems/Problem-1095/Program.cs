namespace Problem_1095;

internal class Program
{
    static void Main(string[] args)
    {
        double selsi = double.Parse(Console.ReadLine()!);
        Console.WriteLine((selsi + 273.15).ToString("0.00000"));
        Console.WriteLine((selsi * 1.80 + 32.00).ToString("0.00000"));
    }
}
