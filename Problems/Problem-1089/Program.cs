namespace Problem_1089;

internal class Program
{
    static void Main(string[] args)
    {
        var unit = new Dictionary<int, string>()
        {
            { 1, "bir" }, { 2, "ikki" }, { 3, "uch" }, { 4, "to'rt" },
            { 5, "besh" }, { 6, "olti" }, { 7, "yetti" }, { 8, "sakkiz" }, { 9, "to'qqiz" }
        };

        var tens = new Dictionary<int, string>()
        {
            {1,"o'n" },{2,"yigirma" },{3,"o'ttiz" },{4,"qirq" },{5,"ellik" },
            {6,"oltmish" },{7,"yetmish" },{8,"sakson" },{9,"to'qson" }
        };

        var num = int.Parse(Console.ReadLine());

        if (num.ToString().Length == 4)
        {
            Console.WriteLine("bir ming");
            return;
        }
        else if (num == 0)
        {
            Console.WriteLine("nol");
            return;
        }

        while (num > 0)
        {

            int divider = (int)Math.Pow(10, num.ToString().Length - 1);
            if (num.ToString().Length == 3)
            {
                Console.Write(unit.GetValueOrDefault(int.Parse(num.ToString()[0].ToString())) + " yuz ");
            }
            else if (num.ToString().Length == 2)
            {
                Console.Write(tens.GetValueOrDefault(int.Parse(num.ToString()[0].ToString())) + " ");
            }
            else if (num.ToString().Length == 1)
            {
                Console.Write(unit.GetValueOrDefault(int.Parse(num.ToString()[0].ToString())) + " ");
            }

            num = num % divider;
        }

    }
}
