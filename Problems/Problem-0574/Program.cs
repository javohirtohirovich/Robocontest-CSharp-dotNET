namespace Problem_0574;

internal class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < nums[1]; i++)
        {
            Console.ReadLine();
        }
        Console.WriteLine(nums[0] * nums[1]);
    }
}
