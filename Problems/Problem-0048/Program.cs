namespace Problem_0048;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = 1;
        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j<=i; j++)
            {
                Console.Write($"{k} ");
                k++;
            }
            Console.WriteLine();
        }
    }
}
