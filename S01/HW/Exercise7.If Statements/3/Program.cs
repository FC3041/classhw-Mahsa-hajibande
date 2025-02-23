namespace _3;

class Program
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
        rocketship_base (5) ;
    }
}
