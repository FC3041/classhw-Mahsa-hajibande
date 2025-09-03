namespace _2;

class Program
{
    double CtoF (int C)
    {
        double F = (C * 1.8) + 32 ;
        return F ;
    }
    static void Main(string[] args)
    {
        Program program = new Program () ;
        Console.WriteLine (program.CtoF (0)) ;
    }
}
