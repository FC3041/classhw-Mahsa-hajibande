namespace _4;

public class Program
{
    static int factorial (int n)
    {
        if (n == 1)
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
        int n = 5 ;
        for (int j = 1 ; j <= n ; j++)
        {
            Console.WriteLine (factorial (j)) ;
        }
    }
}
