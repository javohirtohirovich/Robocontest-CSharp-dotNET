namespace Problem_0028;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var cordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ax = cordinates[0], ay = cordinates[1], bx = cordinates[2], by = cordinates[3];

            Console.WriteLine($"{2 * bx - ax} {2 * by - ay}");
        }
    }
}
