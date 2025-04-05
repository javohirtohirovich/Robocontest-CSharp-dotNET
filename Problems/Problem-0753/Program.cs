using System.Globalization;

namespace Problem_0753;

internal class Program
{
    static void Main(string[] args)
    {
        // Kiruvchi ma'lumotlarni o'qish
        string[] input = Console.ReadLine().Split();
        double x = double.Parse(input[0], CultureInfo.InvariantCulture);
        double y = double.Parse(input[1], CultureInfo.InvariantCulture);

        // Formulani hisoblash
        double numerator = (1 / x) + (2 / (x * x)) + (3 / (x * x * x)) + Math.Exp(x * x + 3 * x);
        double denominator = Math.Atan(x + y) + Math.Pow(Math.Abs(5 + x), 2) - Math.Pow(Math.Cos(y * y + (x * x) / 2), 2);

        double F = numerator / denominator;

        // Natijani 2 xonali aniqlik bilan chiqarish
        Console.WriteLine(F.ToString("F2", CultureInfo.InvariantCulture));
    }
}
