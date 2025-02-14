namespace _1;

class Program
{
    void head ()
    {
        Console.WriteLine ("          ^          ") ;
        Console.WriteLine ("         /|\\        ") ;
        Console.WriteLine ("        //|\\\\      ") ;
        Console.WriteLine ("       ///|\\\\\\    ") ;
    }

    void body (int n)
    {
        Console.WriteLine ("      +-------+      ") ;
        for (int i = 0 ; i < n ; i++)
        {
            Console.WriteLine ("      +*******+      ") ;
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.head();
        program.body(6);
        program.body(6);
        program.body(6);
        Console.WriteLine ("      +-------+      ") ;
        program.head();
    }
}
