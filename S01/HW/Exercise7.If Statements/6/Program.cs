﻿namespace _6;

class Program
{
    static void month_number (int n)
    {
        if (n == 1)
        {
            Console.WriteLine ("January") ;
        }
        else if (n == 2)
        {
            Console.WriteLine ("February") ;
        }
        else if (n == 3)
        {
            Console.WriteLine ("March") ;
        }
        else if (n == 4)
        {
            Console.WriteLine ("April") ;
        }
        else if (n == 5)
        {
            Console.WriteLine ("May") ;
        }
        else if (n == 6)
        {
            Console.WriteLine ("June") ;
        }
        else if (n == 7)
        {
            Console.WriteLine ("July") ;
        }
        else if (n == 8)
        {
            Console.WriteLine ("August") ;
        }
        else if (n == 9)
        {
            Console.WriteLine ("September") ;
        }
        else if (n == 10)
        {
            Console.WriteLine ("October") ;
        }
        else if (n == 11)
        {
            Console.WriteLine ("November") ;
        }
        else if (n == 12)
        {
            Console.WriteLine ("December") ;
        }
    }
    static void Main(string[] args)
    {
        for (int i = 1 ; i <= 12 ; i++)
        {
            Console.Write (i) ;
            Console.Write ("-") ;
            month_number (i) ;
        }
    }
}
