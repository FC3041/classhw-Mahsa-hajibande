namespace _2;

class Program
{
    static void left_triangle (int n)
    {
        for (int i = 1 ; i <= n ; i++)
        {
            for (int j = 1 ; j <= i ; j++)
            {
                if (i % 2 == 1)
                {
                    Console.Write ("%") ;
                }
                else
                {
                    Console.Write ("*") ;
                }
            }
            Console.WriteLine () ;
        }
    }
    static void Main(string[] args)
    {
        left_triangle (5) ;
    }
}
