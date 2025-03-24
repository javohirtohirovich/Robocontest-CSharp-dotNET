namespace Problem_0392;

internal class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        foreach(var i in nums)
        {
            Console.WriteLine(i/2);
        }
    }
}
