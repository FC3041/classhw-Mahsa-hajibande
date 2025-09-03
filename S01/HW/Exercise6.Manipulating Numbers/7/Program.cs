namespace _7;

class Program
{
    static double power (int x)
    {
        return x * x ;
    }
    static double sum (int n)
    {
        double sum = 0 ;
        for (int i =  0 ; i < n ; i++)
        {
            sum += power (i) ;
        }
        return sum ;
    }
    static void average (int n)
    {
        double average = sum (n) / (n-1) ;
        Console.WriteLine (average) ;
    }
    static void Main(string[] args)
    {
        average (4) ;
    }
}
