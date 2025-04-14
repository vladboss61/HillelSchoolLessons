using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Models;

public class Vehicle
{
    private string generalDescription; // Not available in Car
    public string brand;
    protected int speed = 100;

    public void Honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field

    public Car()
    {
        base.speed = 150;
        base.brand = "Ford";
    }
}
