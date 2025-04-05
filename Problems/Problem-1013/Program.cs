namespace Problem_1013;

internal class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine();
        int n = 0;
        foreach(char c in s)
        {
            if(c == '1')
            {
                n++;
            }
        }
        if(n % 2 == 0)
        {
            Console.WriteLine("NO");
        }
        else
        {
            Console.WriteLine("YES");
        }
    }
}
