using System;

class Program
{
    static void Main(string[] args)
    {
        //List of shapes
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("blue", 5));
        shapes.Add(new Rectangle("green", 2, 6));
        shapes.Add(new Circle("purple", 3.25));

        //display color and area of each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area {shape.GetArea()}");
        }

    }
}