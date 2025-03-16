namespace Problme_0113;

internal class Program
{
    static void Main(string[] args)
    {
        double asl_baho = int.Parse(Console.ReadLine());

        double karrali = Math.Ceiling(asl_baho / 5);

        double joriy_baho;
        if (karrali * 5 - asl_baho < 3 && asl_baho > 37)
        {
            joriy_baho = karrali * 5;
        }
        else
        {
            joriy_baho = asl_baho;
        }
        Console.WriteLine(joriy_baho);
    }
}
