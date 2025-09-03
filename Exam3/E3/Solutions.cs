using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace E3;

public class Animal
{
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }
}

public class Dog : Animal
{
    public override string MakeSound()
    {
        return "Woof";
    }
}

public class MyPointType1
{
    public int X { get; set; }
    public int Y { get; set; }
}

public struct MyPointType2
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class Comparer<T> where T : IComparable<T> 
{
    public T Item1;
    public T Item2;
    public Comparer(T item1, T item2)
    {
        Item1 = item1;
        Item2 = item2;
    }
    public T GetLarger()
    {
        int x = Item1.CompareTo(Item2);
        if (x > 0)
        {
            return Item1;
        }
        else
        {
            return Item2;
        }
    }
}

public class Product : IComparable<Product>
{
    public string Name { get; set; }
    public int Price { get; set; }

    public int CompareTo(Product other)
    {
        return (this.Price).CompareTo(other.Price);
    }
}

public class DelegateProblems
{
    public delegate string StringOperation(string s);
    public static string ToUpper(string s) => s.ToUpper();
    public static string ToLower(string s) => s.ToLower();
    public static string ProcessString(string s, StringOperation op)
    {
        return op(s);
    }
}

//public class LinqProblems
//{
//    public List<int> nums = new List<int>()
//                          .Where (n => n>5 && n%2 == 0)
//    
//}

public class Money : IEquatable<Money>
{
    public int Amount;
    public string Name;
    public Money(int amount, string name)
    {
        Amount = amount;
        Name = name;
    }
    public static Money operator +(Money a, Money b)
    {
        int Sum = a.Amount + b.Amount;
        return new Money (Sum , a.Name);
    }

    public static bool operator ==(Money a, Money b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(Money a, Money b)
    {
        return !a.Equals(b);
    }

    public bool Equals(Money other)
    {
        return this.Amount == other.Amount && this.Name == other.Name;
    }
}


public class ResourceManager : IDisposable
{
    public bool IsDisposed = false;
    public void Dispose()
    {
        IsDisposed = true;
    }

}

public class LinqProblems
{
    public static List<int> FilterAndDouble(List<int> nums)
    {
        List<int> result = nums.Where(x => x > 5).Select(x => x % 2).ToList();
        return result;
    }
}