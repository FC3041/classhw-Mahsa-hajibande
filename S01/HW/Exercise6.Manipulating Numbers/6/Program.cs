namespace _6;

class Program
{
    static void quadradic (int a , int b , int c)
    {
        double delta = ((b*b) - (4*a*c)) ;
        if (delta < 0)
        {
            Console.WriteLine ("no routs...!") ;
        }
        else
        {
            double x1 = ((-b+Math.Sqrt(delta))/(2*a)) ;
            double x2 = ((-b-Math.Sqrt(delta))/(2*a)) ;
            Console.WriteLine (x1) ;
            Console.WriteLine (x2) ;
        }
    }
    static void Main(string[] args)
    {
        
        quadradic (1,2,-3) ;
    }
}
