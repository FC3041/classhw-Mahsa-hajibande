namespace _3;

class Program
{
     void left_triangle (int n , char a)
    {
        for (int i = 1 ; i < n+1 ; i++)
        {
            for (int j = 1 ; j <= i ; j++)
            {
                Console.Write (a) ;
            }
            Console.WriteLine() ;
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program() ;
        program.left_triangle (5,'%') ;
        program.left_triangle (5,'*') ;
    }
}
