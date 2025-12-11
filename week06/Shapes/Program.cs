using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        
        // Square
        Square square = new Square();
        square.SetColorAndSide("Red", 10);
        double area = square.GetArea();
        Console.WriteLine($"The area of the square is: {area}");

        // Rectangle
        Rectangle rectangle = new Rectangle();
        rectangle.SetColorAndDimensions("Blue", 5, 10);
        area = rectangle.GetArea();
        Console.WriteLine($"The area of the rectangle is: {area}");

        // Circle
        Circle circle = new Circle();
        circle.SetColorAndRadius("Green", 7);
        area = circle.GetArea();
        Console.WriteLine($"The area of the circle is: {area}");

        Console.WriteLine("---------------------");

        // List of Shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        // Display Colors
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            area = shape.GetArea();
            Console.WriteLine($"The shape is: {shape}");
            Console.WriteLine($"The color of the shape is: {color}");
            Console.WriteLine($"The area of the shape is: {area}");
            Console.WriteLine("---------------------");
        }
    }
}