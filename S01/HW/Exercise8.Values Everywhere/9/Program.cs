namespace _9;

class Program
{
    public static int Dayofweek (int year , int month , int day)
    {
        if (month < 3)
        {
            month += 12 ;
            year -= 1 ;
        }
        int i = year % 100 ;
        int j = year / 100 ;
        int dayofweek = (day + (13 * (month + 1)) / 5 + i + (i / 4) + (j / 4) + 5 * j) % 7 ;
        dayofweek = (dayofweek + 6) % 7 ;
        return dayofweek ;
    }
    public static void Main(string[] args)
    {
        int year = 2014 ;
        int month = 6 ;
        int year = 18 ;
        int dayofweek = Dayofweek (year , month , day) ;
        Console.WriteLine (dayofweek) ;
    }
}
