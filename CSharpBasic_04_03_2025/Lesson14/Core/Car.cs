using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson14.Core;

internal class Car
{
    private string model;

    private int age;

    public Car(string model, int age)
    {
        this.model = model;
        this.age = age;
    }

    public string Model
    {
        get {
            return model;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0 && value < 120)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Wrong age value");
            }
        }
    }

    public void SetAge(int age)
    {
        if (age > 0 && age < 120)
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("Wrong age value");
        }
    }
}
