namespace Problem_3;

internal class Program
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        string result = "";

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digit1 = (i >= 0) ? a[i] - '0' : 0;
            int digit2 = (j >= 0) ? b[j] - '0' : 0;

            int sum = digit1 + digit2 + carry;
            carry = sum / 10;

            result = (sum % 10).ToString() + result;

            i--;
            j--;
        }

        Console.WriteLine(result);
    }
}
