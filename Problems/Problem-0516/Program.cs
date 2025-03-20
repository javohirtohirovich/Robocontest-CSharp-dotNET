namespace Problem_0516;

internal class Program
{
    static void Main(string[] args)
    {
        var arrNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (arrNums[0] + arrNums[1] < arrNums[2])
        {
            Console.WriteLine("Error");
        }
        else
        {
            Console.WriteLine(arrNums[0] + arrNums[1] - arrNums[2]);
        }
    }
}
