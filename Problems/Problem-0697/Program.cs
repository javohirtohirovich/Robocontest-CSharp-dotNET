namespace Problem_0697;

internal class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int sum = 0;
        foreach (char c in s)
        {
            sum += (int)c;
        }
        Console.WriteLine(sum);
    }
}
