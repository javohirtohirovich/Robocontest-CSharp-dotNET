namespace Problem_1099;

internal class Program
{
    static void Main(string[] args)
    {
        var val = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long a = val[0];
        long b = val[1];
        long s = 0;
        var j = 1;
        for (long i = a; i <= b; i=+j)
        {
            if(i%3 == 0 && i%7!=0)
            {
                s+= i;
                j = 3;
            }
        }
        Console.WriteLine(s);

    }
}
