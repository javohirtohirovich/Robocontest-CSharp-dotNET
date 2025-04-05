namespace Problem_1067;

internal class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int a = 1; a < Math.Sqrt(nums[1]) + 1; a++)
        {
            if (nums[1] % a == 0)
            {
                int b = nums[1] / a;
                if (a + b == nums[0])
                {
                    Console.WriteLine(a + " " + b);
                    return;
                }
            }
        }
        Console.WriteLine(-1);
    }
}
