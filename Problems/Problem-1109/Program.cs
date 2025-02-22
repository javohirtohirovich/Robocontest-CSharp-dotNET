namespace Problem_1109;

internal class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(nums[0] * nums[1] / 2);
    }
}
