namespace Problem_0301;

public class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var hint = true;
        for(int i  = 0; i < numbers.Length-1; i++)
        {
            if(numbers[i] > numbers[i + 1])
            {
                hint = false;
                break;
            }
        }

        if(hint)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
