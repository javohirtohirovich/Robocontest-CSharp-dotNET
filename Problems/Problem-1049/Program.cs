namespace Problem_1049;

internal class Program
{
    static void Main(string[] args)
    {
        var ticket = Console.ReadLine();
        var ishora = false;
        for(int i = 0; i<ticket.Length-1; i++)
        {
            if (ticket[i] == '1' && ticket[i+1]=='3')
            {
                ishora = true;
                break;
            }
        }
        if(ishora) Console.WriteLine("omadsiz chipta");
        else Console.WriteLine("omadli chipta");
    }
}
