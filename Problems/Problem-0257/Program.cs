namespace Problem_0257;

internal class Program
{
    static void Main(string[] args)
    {
        var satr = Console.ReadLine();
        var index = satr.IndexOf("1");
        if (index == -1) 
        {
            Console.WriteLine("NO"); 
        }

        var zeroIndex = -1;
        for (int i = index; i < satr.Length; i++)
        {
            if (satr[i] == '0') 
            {
                zeroIndex = i; 
                break; 
            }
        }
        if(zeroIndex == -1)
        {
            Console.WriteLine("YES");
            return;
        }

        for (int i = zeroIndex; i < satr.Length; i++)
        {
            if (satr[i] == '1') 
            { 
                Console.WriteLine("NO"); 
                return; 
            }
        }

        Console.WriteLine("YES");
    }
}
