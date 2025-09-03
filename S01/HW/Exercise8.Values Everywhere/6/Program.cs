namespace _6;

class Program
{
    static int daysinmonth (int n)
    {
        if (n > 12 || n < 1)
        {
            Console.WriteLine ("the number must be more than 0 and less than 12.") ;
            return -1 ;
        }
        else
        {
            if (n == 1 || n == 3 || n == 5 || n == 7 || n == 8 || n == 10 || n == 12)
            {
                return 31 ;
            }
            else if (n == 2)
            {
                return 28 ;
            }
            else
            {
                return 30 ;
            }
        }
    }
    static void Main(string[] args)
    {
        int days = daysinmonth (4) ;
        if (days != -1)
        {
            Console.WriteLine (days) ;
        }
    }
}
