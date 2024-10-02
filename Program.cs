using System;

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

}

public class Rectangle : Shape
{
    private double width, height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }

}

internal class Program
{   
    static void Main(string[] args)
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 3);

        Console.WriteLine($"Area of Circle: {circle.GetArea():F2}");
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");
        Console.ReadKey();

    }

}