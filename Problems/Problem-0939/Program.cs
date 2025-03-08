namespace Problem_0939;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if(n==1 || n == 10)
        {
            Console.WriteLine("VIP 210K");
        }
        else if(n<8)
        {
            Console.WriteLine("Econom 105K");
        }
        else
        {
            Console.WriteLine("Business 140K");
        }
    }
}
