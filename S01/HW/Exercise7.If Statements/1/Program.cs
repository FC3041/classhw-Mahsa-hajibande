namespace _1;

class Program
{
    static void leapyear (int year)
    {
        if ((year % 400) == 0 || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine ("it is a leap year") ;
        }
        else
        {
            Console.WriteLine ("it is not a leap year") ;
        }
    }
    static void Main(string[] args)
    {
        leapyear (1940) ;
    }
}
