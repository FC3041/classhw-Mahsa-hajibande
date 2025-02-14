namespace _1;

class Program
{
    static void absolute (int n)
    {
        if (n < 0)
        {
            Console.WriteLine ("this number is negative") ;
        }
        else if (n > 0)
        {
            Console.WriteLine ("this number is positive") ;
        }
        else if (n == 0)
        {
            Console.WriteLine ("not negative and not positive.this is zero ...!") ;
        }
    }
    static void Main(string[] args)
    {
        absolute (100) ;
        absolute (-100) ;
        absolute (0) ;
        absolute (1) ;
        absolute (-1) ;
    }
}
