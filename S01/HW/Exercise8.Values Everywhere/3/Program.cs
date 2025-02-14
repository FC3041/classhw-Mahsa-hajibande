namespace _3;

class Program
{
    static bool is_divisible (int a , int b)
    {
        return a % b == 0 ;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(is_divisible (10,5));
    }
}
