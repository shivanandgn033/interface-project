using System;

// Define the interface
public interface IDrawable
{
    // Method signature for drawing
    void Draw();

    // Property signature for color (read-only)
    string Color { get; }
}

// Class implementing the IDrawable interface
public class Circle : IDrawable
{
    public int Radius { get; set; }
    public string Color { get; }

    public Circle(int radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    // Implementation of the Draw method
    public void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {Radius} and color {Color}");
    }
}

// Another class implementing the IDrawable interface
public class Rectangle : IDrawable
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string Color { get; }

    public Rectangle(int width, int height, string color)
    {
        Width = width;
        Height = height;
        Color = color;
    }

    // Implementation of the Draw method
    public void Draw()
    {
        Console.WriteLine($"Drawing a rectangle with width {Width}, height {Height}, and color {Color}");
    }
}

public class Example
{
    public static void Main(stringargs)
    {
        // Create instances of classes that implement IDrawable
        IDrawable circle = new Circle(5, "Red");
        IDrawable rectangle = new Rectangle(10, 7, "Blue");

        // Call the Draw method through the interface reference
        circle.Draw();      // Output: Drawing a circle with radius 5 and color Red
        rectangle.Draw();   // Output: Drawing a rectangle with width 10, height 7, and color Blue

        Console.WriteLine($"Circle Color: {circle.Color}");   // Output: Circle Color: Red
        Console.WriteLine($"Rectangle Color: {rectangle.Color}"); // Output: Rectangle Color: Blue
    }
}