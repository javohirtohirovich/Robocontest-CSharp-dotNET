namespace Problem_0569;

internal class Program
{
    static void Main(string[] args)
    {
        var str = Console.ReadLine();
        if(str.Contains("P" as string) || str.Contains("Q" as string) || str.Contains("7" as string))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
