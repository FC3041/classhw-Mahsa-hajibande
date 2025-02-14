namespace _7;

class Program
{
    static bool leapyear (int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ;
    }
    static int dayinmonth (int month , int year)
    {
        if (month > 12 || month < 1)
        {
            Console.WriteLine ("the number must be more than 0 and less than 12.") ;
            return -1 ;
        }
        else
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31 ;
            }
            else if (month == 2)
            {
                if (leapyear (year))
                {
                    return 29 ;
                }
                else
                {
                    return 28 ;
                }
            }
            else
            {
                return 30 ;
            }
        }
    }
    static void Main(string[] args)
    {
        int year = 2025 ;
        int month = 2 ;
        int days = dayinmonth (month , year) ;
        if (days != -1)
        {
            Console.WriteLine (dayinmonth (month , year)) ;
        }
    }
}
