using Lesson14.Core;
using Microsoft.VisualBasic;

namespace Lesson14;

internal class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("Audi", 5);

        audi.Age = 125;
        audi.SetAge(125);

        Circle defaultCircle = new Circle();

        //Circle smallCircle = new Circle() { radius = 4.5, measure = Measure.Mm };
        //Circle simpleCircle = new Circle() { measure = Measure.Mm };

        Circle smallCircle = new Circle(4.5, Measure.Mm);
        smallCircle.radius = 10;
        Circle simpleCircle = new Circle(9.5);

        Console.WriteLine("Before Changes");

        smallCircle.Print();

        double smallCircleDiameter = smallCircle.GetDiameter();
        Console.WriteLine($"Small Diameter: {smallCircleDiameter}");

        Console.WriteLine("After Changes");

        smallCircle.radius = 2;
        smallCircle.measure = Measure.Cm;

        smallCircle.Print();

        Circle bigCircle = new Circle() { radius = 12.55, measure = Measure.Cm };

        bigCircle.Print();

        double bigCircleDiameter = bigCircle.GetDiameter();

        Console.WriteLine($"Big Diameter: {bigCircleDiameter}");
    }
}
