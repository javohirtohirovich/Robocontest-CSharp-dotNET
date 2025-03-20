namespace Problem_0550;

internal class Program
{
    static void Main(string[] args)
    {
        var arrNums = Console.ReadLine().Split().Select(double.Parse).ToArray();
        if (arrNums[0] >= arrNums[1])
        {
            Console.WriteLine(Math.Ceiling((arrNums[0] - arrNums[1])/10));
        }
        else if (arrNums[0] <= arrNums[1])
        {
            Console.WriteLine(Math.Ceiling((arrNums[1] - arrNums[0])/10));
        }
    }
}
