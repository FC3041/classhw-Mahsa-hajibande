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

    void body ()
    {
        Console.WriteLine ("      +-------+      ") ;
        Console.WriteLine ("      +*******+      ") ;
        Console.WriteLine ("      +*******+      ") ;
        Console.WriteLine ("      +*******+      ") ;
        Console.WriteLine ("      +*******+      ") ;
        Console.WriteLine ("      +-------+      ") ;
        Console.WriteLine ("      +*******+      ") ;
        Console.WriteLine ("      +*******+      ") ;
        Console.WriteLine ("      +*******+      ") ;
        Console.WriteLine ("      +*******+      ") ;
        Console.WriteLine ("      +-------+      ") ;
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.head();
        program.body();
        program.head();
    }
}
