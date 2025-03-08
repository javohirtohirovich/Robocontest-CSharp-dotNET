namespace Problem_1068;

internal class Program
{
    static void Main(string[] args)
    {
        var fullname = Console.ReadLine().Split().ToArray();
        if (fullname[0][fullname[0].Length - 1] == 'v')
        {
            Console.WriteLine($"{fullname[1]} {fullname[0]}");
        }
        else
        {
            Console.WriteLine($"{fullname[0]} {fullname[1]}");
        }
    }
}