namespace _2;

class Program
{
    static int factorial (int n)
    {
        if (n == 0)
        {
            return 1 ;
        }
        else if (n == 1)
        {
            return 1 ;
        }
        else
        {
            return n * factorial (n-1) ;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine (factorial (5)) ;
    }
}
