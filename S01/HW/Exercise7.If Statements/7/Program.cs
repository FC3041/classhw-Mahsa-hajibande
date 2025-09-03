namespace _7;

class Program
{
    static void ComputeChange (int n)
    {
        if (n >= 100 || n < 0)
        {
            Console.WriteLine ("the amount shoult be more than 0 and less than 100") ;
        }
        else
        {
            int quarters = n / 25 ;
            n = n % 25 ;
            int dimes = n / 10 ;
            n = n % 10 ;
            int nickels = n / 5 ;
            n = n % 5 ;
            int pennies = n ;
            Console.Write ("quarters : ") ;
            Console.WriteLine (quarters) ;
            Console.Write ("dimmes : ") ;
            Console.WriteLine (dimes) ;
            Console.Write ("nickels : ") ;
            Console.WriteLine (nickels) ;
            Console.Write ("pennies : ") ;
            Console.WriteLine (pennies) ;
        }
    }
    static void Main(string[] args)
    {
        ComputeChange (97) ;
    }
}
