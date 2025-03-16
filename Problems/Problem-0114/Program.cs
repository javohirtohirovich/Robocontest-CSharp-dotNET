namespace Problem_0114;

internal class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int x1 = nums[0], v1 = nums[1], x2 = nums[2], v2 = nums[3];

        if (v1 == v2)
        {
            Console.WriteLine(x1 == x2 ? "YES" : "NO");
        }
        else
        {
            int dx = x2 - x1;
            int dv = v1 - v2;

            if (dx % dv == 0 && dx / dv >= 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
