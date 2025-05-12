namespace _1;

class Program
{
    double FtoC (int F)
    {
        double C = (F - 32) * 5.9 ;
        return C ;
    }
    static void Main(string[] args)
    {
        Program program = new Program () ;
        Console.WriteLine (program.FtoC (33)) ;
    }
}
