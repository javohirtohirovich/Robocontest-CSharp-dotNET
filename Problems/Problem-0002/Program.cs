namespace Problem_2;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        if (input[0]>input[1])
        {
            Console.WriteLine('>');
        }
        else if (input[0]<input[1])
        {
            Console.WriteLine('<');
        }
        else
        {
            Console.WriteLine('=');
        }
    }
}
