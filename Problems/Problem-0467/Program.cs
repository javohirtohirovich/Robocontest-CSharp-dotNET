namespace Problem_0467;

internal class Program
{
    static void Main(string[] args)
    {
        var arrNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (arrNums[1] % 2 != 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(arrNums[0] + arrNums[1] / 2 + 1);
        }
    }
}
