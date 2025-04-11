namespace Problem_1191;

internal class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(long.Parse).ToArray();
        // nums[0] = n, nums[1] = m, nums[2] = k, nums[3] = d
        if ((nums[0] * nums[1] + nums[3]) < (nums[0] * nums[2]))
        {
            Console.WriteLine(nums[0] * nums[1] + nums[3]);
        }
        else
        {
            Console.WriteLine(nums[0] * nums[2]);
        }
    }
}
