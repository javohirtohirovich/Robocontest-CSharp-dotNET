namespace Problem_0082;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("Second player");
        }
        else
        {
            Console.WriteLine("First player");
        }
    }
}
