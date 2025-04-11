using System.Text;

namespace Problem_1097;

internal class Program
{
    static void Main(string[] args)
    {
        var num = Console.ReadLine();
        StringBuilder sb = new StringBuilder(num);

        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] != '9')
            {
                sb[i] = '9';
                break;
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
