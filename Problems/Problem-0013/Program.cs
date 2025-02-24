namespace Problem_0013;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (numbers[0] == 0 )
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(numbers[1]+1);
        }
    }
}
