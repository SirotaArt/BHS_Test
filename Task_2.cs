using System;

public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Машина едет");
    }
}

public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Велосипед катится");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();
        bicycle.Move();
    }
}
