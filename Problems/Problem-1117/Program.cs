namespace Problem_1117;

internal class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var first_gap = nums[1] - nums[0];
        var second_gap = nums[2] - nums[1];

        if (first_gap > second_gap)
        {
            Console.WriteLine(first_gap - 1);
        }
        else
        {
            Console.WriteLine(second_gap - 1);
        }
    }
}
