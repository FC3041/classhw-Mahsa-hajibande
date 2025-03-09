namespace _4;

public class Program
{
    static void rocketship_base (int n)
    {
        double x = n/2 ;
        int y = (int) x ;
        for (int i = 1 ; i <= y ; i++)
        {
            for (int j = 1 ; j <= n - i ; j++)
            {
                Console.Write (" ") ;
            }
            for (int j = 1 ; j <= i ; j++)
            {
                Console.Write ("/") ;
            }
            Console.Write ("|") ;
            for (int j = 1 ; j <= i ; j++)
            {
                Console.Write ("\\") ;
            }
            Console.WriteLine () ;
        }
    }
    static void Main(string[] args)
    {
        for (int i = 0 ; i <= 9 ; i++)
        {
            if (i % 2 == 1)
            {
               rocketship_base (i) ;
            }
        }
    }
}
