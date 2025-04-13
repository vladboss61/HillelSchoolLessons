using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14.Core;

class Person
{
    // Fields
    public string name = "Undefined";   // ім'я
    public int age;                     // вік

    private string country;

    // 1 конструктор
    public Person()
    {
        name = "Unknown";
        age = 18;
        country = "Ukraine";
    }

    // 2 конструктор
    public Person(string name)
    {
        this.name = name;
        age = 18;
        country = "Ukraine";
    }

    // 3 конструктор
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {name}  Surname: {age}");
    }
}
