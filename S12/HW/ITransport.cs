using System;

namespace Transport
{
    public interface ITransport
    {
        public int WheelNum();
        public int Capacity();
    }

    public class Bike : ITransport
    {
        public int W;
        public int C;

        public Bike (int a, int b)
        {
            W = a;
            C = b;
        }

        public int WheelNum()
        {
            return W;
        }

        public int Capacity()
        {
            return C;
        }
    }

    public class Car : ITransport
    {
        public int W;
        public int C;

        public Car (int a, int b)
        {
            W = a;
            C = b;
        }

        public int WheelNum()
        {
            return W;
        }

        public int Capacity()
        {
            return C;
        }
    }

    public class Truck : ITransport
    {
        public int W;
        public int C;

        public Truck (int a, int b)
        {
            W = a;
            C = b;
        }

        public int WheelNum()
        {
            return W;
        }

        public int Capacity()
        {
            return C;
        }
    }
}
