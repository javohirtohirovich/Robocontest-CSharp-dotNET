namespace Probelm_372;

internal class Program
{
    static void Main(string[] args)
    {
        // 1-Version

        //var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //if (numbers[0] > numbers[1])
        //{
        //    if (numbers[0] > numbers[2])
        //    {
        //        Console.WriteLine(numbers[0]);
        //    }
        //    else
        //    {
        //        Console.WriteLine(numbers[2]);
        //    }
        //}
        //else
        //{
        //    if (numbers[1] > numbers[2])
        //    {
        //        Console.WriteLine(numbers[1]);
        //    }
        //    else
        //    {
        //        Console.WriteLine(numbers[2]);
        //    }
        //}

        //  2-Version

        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        Console.WriteLine(max);
    }
}
