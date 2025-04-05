namespace Problem_1030;

internal class Program
{
    static void Main(string[] args)
    {
        var inpArr = Console.ReadLine()!.Split().ToList();
        var a = int.Parse(inpArr[0]);
        var b = int.Parse(inpArr[1]);
        var c = 1;
        var d = 1;
        switch (inpArr[2])
        {
           
            case "*":
                c = 1;
                d = a * b / c;
                break;

            case "/":
                c = a * 10;
                d = b * 10;
                break;

            case "+":
                c = a - 1;
                d = (a+b) - c;
                break;

            case "-":
                c = a + 20;
                d = c + (b - a);
                break;
           

        }
        Console.WriteLine(c + " " + d);
    }
}
