using System;


public abstract class Shape
{
    
    public abstract double GetArea();
}


public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }


    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}


public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }


    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Abstract Classes and Methods ---");
        

        Circle myCircle = new Circle(5);
        Rectangle myRectangle = new Rectangle(10, 4);


        Console.WriteLine($"Area of the circle: {myCircle.GetArea():F2}");
        Console.WriteLine($"Area of the rectangle: {myRectangle.GetArea()}");
    }
}