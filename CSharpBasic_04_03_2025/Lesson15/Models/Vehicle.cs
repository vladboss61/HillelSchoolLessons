using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Models;

public class Vehicle
{
    public string Brand;
    public string Name;

    public Vehicle(string brand)
    {
        Console.WriteLine(brand);
        this.Brand = brand;
    }

    public Vehicle(string brand, string name) : this(brand)
    {
        Console.WriteLine(name);
        this.Name = name;
    }

    public virtual void Honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public int Speed;

    public Car(string brand, string name, int speed) : base(brand, name)
    {
        Console.WriteLine(speed);
        this.Speed = speed;
    }

    public override void Honk()
    {
        Console.WriteLine("Bip bip!");
    }
}

public class Bus : Vehicle
{
    public string BusName { get; set; }

    public Bus(string brand, string busName) : this(brand)
    {
        BusName = busName;
    }

    public Bus(string brand) : base(brand)
    {
    }

    public override void Honk()
    {
    
        Console.WriteLine("Trubon, Trubon");
    }
}
