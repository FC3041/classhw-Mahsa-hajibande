namespace _5;

class Program
{
    static int fibonacci (int n)
    {
        if (n == 1)
        {
            return 1 ;
        }
        else if (n == 2)
        {
            return 1 ;
        }
        else
        {
            return fibonacci (n-1) + fibonacci (n-2) ;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine (fibonacci (6)) ;
    }
}
