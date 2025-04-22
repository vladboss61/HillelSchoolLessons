using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Models;

public class Shape //: object // Кожний класс успадковується від object за замовчуванням
                   //  в якому э 3 методи (virtual toString(), vitural Equals(), vitural GetHashCode(), GetType())
{
    // A few example members
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Height { get; set; }
    public int Width { get; set; }

    // Virtual method
    public virtual void Draw()
    {
        Console.WriteLine("Performing base class drawing tasks");
    }

    public sealed override string ToString()
    {
        return "This is Shape";
    }
}

public sealed class Circle : Shape
{
    public override void Draw()
    {
        // Code to draw a circle...
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public sealed override void Draw()
    {
        // Code to draw a rectangle...
        Console.WriteLine("Drawing a rectangle");
    }

    public virtual int GetWith()
    {
        return Width;
    }
}

public sealed class Square : Rectangle
{
    public override int GetWith()
    {
        return 10;
    }
}

public sealed class Triangle : Shape
{

    public override sealed void Draw()
    {
        // Code to draw a triangle...
        Console.WriteLine("Drawing a triangle");
    }
}
