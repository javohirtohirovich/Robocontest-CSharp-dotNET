namespace Problem_1091;

internal class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var uniqueCount = 3;
        if (nums[0] == nums[1] && nums[1] == nums[2])
        {
            uniqueCount = 1;
        }
        else if (nums[0] == nums[1] || nums[0] == nums[2] || nums[1] == nums[2])
        {
            uniqueCount = 2;
        }
        Console.WriteLine(uniqueCount);
    }
}
