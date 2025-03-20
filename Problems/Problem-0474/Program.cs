namespace Problem_0474;

internal class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        if(n % 2 == 0)
        {
            Console.WriteLine("G'ani");
        }
        else
        {
            Console.WriteLine("Ali");
        }
    }
}
