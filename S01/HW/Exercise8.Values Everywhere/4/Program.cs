namespace _4;

class Program
{
    static bool is_prime (int n)
    {
        if (n <= 1)
        {
            return false ;
        }
        for (int i = 2 ; i <= (int)Math.Sqrt (n) ; i++)
        {
            if (n % i == 0)
            {
                return false ;
            }
        }
        return true ;
    }
    static void primenumbers (int m)
    {
        for (int j = 0 ; j <= m ; j++)
        {
            if (is_prime (j))
            {
                Console.WriteLine (j) ;
            }
        }
    }
    static void Main(string[] args)
    {
        primenumbers (100) ;
    }
}
