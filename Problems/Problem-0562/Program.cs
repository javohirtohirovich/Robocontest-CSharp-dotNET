namespace Problem_0562;

internal class Program
{
    static void Main(string[] args)
    {
        var stones = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var piledUpStones = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x=>x).ToArray();
        var s = 0l;
        if(piledUpStones.Length == 0)
        {
            Console.WriteLine(-1);
            return;
        }
        for (int i = 0; i < piledUpStones.Length; i++)
        {
            s += piledUpStones[i];
            if (s >= stones[0])
            {
                Console.WriteLine(i + 1);
                return;
            }
        }
        Console.WriteLine(-1);
    }
}
