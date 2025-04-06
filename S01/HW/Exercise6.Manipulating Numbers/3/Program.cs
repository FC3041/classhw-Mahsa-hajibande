namespace _3;

class Program
{
    int factorial (int n)
    {
        if (n == 0)
        {
            return 1 ;
        }
        else
        {
            return n * factorial (n-1) ;
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program () ;
        Console.WriteLine (program.factorial (3)) ;
    }
}
