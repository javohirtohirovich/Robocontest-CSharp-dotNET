using System.ComponentModel;

namespace Problem_58;

internal class Program
{
    static void Main(string[] args)
    {
        // 1-version

        //var font = Console.ReadLine();

        //switch (font)
        //{
        //    case "1": Console.WriteLine(6); break;
        //    case "2": Console.WriteLine(5); break;
        //    case "3": Console.WriteLine(4); break;
        //    case "4": Console.WriteLine(3); break;
        //    case "5": Console.WriteLine(2); break;
        //    case "6": Console.WriteLine(1); break;
        //}

        // 2-version

        var font = int.Parse(Console.ReadLine());
        Console.WriteLine(7 - font);
    }
}
