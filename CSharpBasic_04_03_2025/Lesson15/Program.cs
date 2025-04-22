using Lesson15.Models;
using System.Text;

namespace Lesson15;

internal class Program
{
    static void Main(string[] args)
    {
        Shape shapeEx = new Shape();
        Console.WriteLine(shapeEx);

        // Nullble types
        int? number = 10;
        if (number.HasValue)
        {
            int result = number.Value;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Number is null");
        }

        Nullable<int> numberNullable = 10;

        if (numberNullable.HasValue)
        {
            int result = numberNullable.Value;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("NumberNullable is null");
        }

        // Поліморфізм (virtual/override, upcast, downcast)
        // Успадкування class Circle : Shape

        // Інкапсуляція - конкретна поведінка обєктів в класах за допомоги методів та полів + private/public/protected/internal

        Shape shape1 = new Triangle(); // upcast

        Triangle triangle = (Triangle)shape1; // downcast

        var shapes = new Shape[]
        {
            new Triangle(),
            new Rectangle(),
            new Circle()
        };

        foreach (Shape shape in shapes)
        {
            //try
            //{
            //    Triangle triangleShape = (Triangle)shape;
            //}
            //catch (InvalidCastException)
            //{
            //    Console.WriteLine("Can not cast");
            //}

            //Triangle triangleShape = shape as Triangle;

            //if (triangleShape != null)
            //{
            //    Console.WriteLine("Yesss shape is Triangle");
            //}
            //else
            //{
            //    Console.WriteLine("Can not cast");
            //}

            if (shape is Triangle triangleShape)
            {
                Console.WriteLine("Yesss shape is Triangle");
            }
            else
            {
                Console.WriteLine("Can not cast");
            }

            shape.Draw();
        }

        var shapeType = Console.ReadLine();

        if (shapeType == "triangle")
        {
            Shape shape = new Triangle();
            DisplayPicture(shape);
        }
        else if(shapeType == "rectangle")
        {
            Shape shape = new Rectangle();
            DisplayPicture(shape);
        }

        //var car = new Car("Ford", "Mustang", 100);

        Circle c = new Circle();
        Triangle t = new Triangle();
        Shape s = new Shape();
        Square square = new Square();

        //c.Draw(); // Drawing a circle
        //t.Draw(); // Drawing a triangle
        //s.Draw(); // Performing base class drawing tasks

        //square.Draw();
    }

    public static void DisplayPicture(Shape shape)
    {
        if (shape is Rectangle rectangle)
        {
            //Logic...
        }

        switch(shape)
        {
            case Triangle triangle:
                Console.WriteLine("Cased to Triangle");
                break;
            case Circle circle:
                Console.WriteLine("Cased to Circle");
                break;
            case Rectangle rectangle1:
                Console.WriteLine("Cased to Rectangle");
                break;
            default:
                break;
        }


        shape.Draw();
        //....
    }

    /// <summary>
    ///     Calculates the area of a rectangle.
    /// </summary>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <returns>The area calculated as width multiplied by height.</returns>
    public static double CalculateArea(double width, double height)
    {
        return width * height;
    }
}
