namespace Problem_0448;

internal class Program
{
    static void Main(string[] args)
    {
        var arrNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var result = arrNums[0] * Math.Pow(arrNums[3], 2) + arrNums[1] * arrNums[3] + arrNums[2];
        if(result == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
