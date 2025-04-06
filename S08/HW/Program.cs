namespace HW;

public class Program
{
    
    public static void String (string s , out string srev)
    {
        srev = "" ;
        string [] MyString = s.Split (" ") ;
        foreach (string Word in MyString)
        {
            srev = Word + " " + srev ;
        }
    }

    public static void Reverse (string s , out string trev)
    {
        trev = "" ;
        foreach (char letter in s)
        {
            trev = letter + trev ;
        }
    }

    static void Main (string[] args)
    {
        String ("my name is Mahsa" , out string srev) ;
        Console.WriteLine (srev) ;
        Reverse ("my name is Mahsa" , out string trev) ;
        Console.WriteLine (trev) ;
    }
}

