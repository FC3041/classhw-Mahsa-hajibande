namespace _2;

class Program
{
    void right_triangle (int n)
    {
        for (int i = 1 ; i < n ;i++)
        {
            for (int j = 0 ; j < n - i ; j++)
            {
                Console.Write (" ") ;
            }
            for (int z = 0 ; z < i ; z++)
            {
                Console.Write ("*") ;
            }
            Console.WriteLine () ;
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program() ;
        program.right_triangle (5) ;
    }
}
