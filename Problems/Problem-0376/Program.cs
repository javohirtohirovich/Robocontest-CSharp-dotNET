namespace Problem_0376;

internal class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        if (n >= 3 && n <= 5)
        {
            Console.WriteLine("Spring");
        }
        else if (n >= 6 && n <= 8)
        {
            Console.WriteLine("Summer");
        }
        else if (n >= 9 && n <= 11)
        {
            Console.WriteLine("Autumn");
        }
        else if(n == 12 || n==1 || n == 2)
        {
            Console.WriteLine("Winter");
        }
        else
        {
            Console.WriteLine("Error");
        }

    }
}
