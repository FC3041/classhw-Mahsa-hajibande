namespace _8;

class Program
{
    static void Pythagorean ()
    {
        for (int a = 0 ; a <= 10 ; a++)
        {
            for (int b = 0 ; b <= 10 ; b++)
            {
                for (int c = 0 ; c <= 10 ; c++)
                {
                    if ((a*a) + (b*b) == (c*c))
                    {
                        Console.WriteLine ($"{a} , {b} , {c}") ;
                    }
                }
            }
        }
    }
    static void Main(string[] args)
    {
        Pythagorean () ;
    }
}
