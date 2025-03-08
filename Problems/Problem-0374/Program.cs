namespace Problem_0374;

internal class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        nums = nums.OrderBy(x => x).ToArray();
        Console.WriteLine(nums[2] - nums[0]);
    }
}
