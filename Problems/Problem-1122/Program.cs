namespace Problem_1122;

internal class Program
{
    static void Main(string[] args)
    {
        var number = Console.ReadLine();
        if (number.Length % 2 == 0)
        {
            Console.WriteLine("NO");
            return;
        }
        var ishora = true;
        for (int i = 0; i < number.Length; i++)
        {
            if (('0' - number[i]) % 2 == 0)
            {
                ishora = false;
                break;
            }
        }
        if(ishora) { Console.WriteLine("YES"); }
        else { Console.WriteLine("NO"); }
    }
}
