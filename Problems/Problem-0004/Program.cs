namespace Problem_4;

public class Program
{
    static void Main(string[] args)
    {
        var inputValues = Console.ReadLine().Split().Select(long.Parse).ToArray();

        Console.WriteLine(inputValues[0] * inputValues[1]);
    }
}
