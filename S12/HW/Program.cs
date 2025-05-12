using System.ComponentModel;
using Transport;

namespace HW;

class Program
{
    static void Main(string[] args)
    {
        ITransport Bike = new Bike (2 , 1) ;
        ITransport Car = new Car (4 , 5) ;
        ITransport Truck = new Truck (8 , 2) ;
        Console.WriteLine($"Bike = Wheels: {Bike.WheelNum()}, Capacity: {Bike.Capacity()}");
        Console.WriteLine($"Car = Wheels: {Car.WheelNum()}, Capacity: {Car.Capacity()}");
        Console.WriteLine($"Truck = Wheels: {Truck.WheelNum()}, Capacity: {Truck.Capacity()}");
    }
}
