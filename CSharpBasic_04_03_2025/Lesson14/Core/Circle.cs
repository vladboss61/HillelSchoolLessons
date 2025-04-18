using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14.Core;

public class Circle
{
    private static double PI = 3.14;
    // Fields

    internal double radius;

    public Measure measure;

    public double diameter;

    public Circle()
    {
        Console.WriteLine(PI);

        Circle.ExampleStaticMethod("Default Constructor");
        
        radius = 10;
        measure = Measure.Cm;
        diameter = GetDiameter();
    }

    public Circle(double radius)
    {
        ExampleStaticMethod("Circle Constructor Only With Radius");
        this.radius = radius;
        this.measure = Measure.Cm;
    }

    public Circle(double radius, Measure measure)
    {
        ExampleStaticMethod("Circle Constructor Only With Radius and Measure");
        this.radius = radius;
        this.measure = measure;
    }

    internal Circle(double radius, Measure measure, string additionalInfo)
    {
        ExampleStaticMethod($"Circle Constructor Only With Radius and Measure {additionalInfo}");
        this.radius = radius;
        this.measure = measure;
    }

    internal double GetDiameter()
    {
        //this.radius = 10;

        // return radius * 2;
        return radius * 2;
    }

    public void Print()
    {
        Console.WriteLine($"Circle has Radius - {radius} and Measure {measure}");
    }


    public static void ExampleStaticMethod(string info)
    {
        Console.WriteLine($"Circle Constructor {info} {PI}");
    }
}
