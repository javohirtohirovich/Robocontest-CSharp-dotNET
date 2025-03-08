namespace Problem_0044;

public class Program
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine("Kabisa yili");
        }
        else
        {
            Console.WriteLine("Kabisa yili emas");
        }
    }
}
