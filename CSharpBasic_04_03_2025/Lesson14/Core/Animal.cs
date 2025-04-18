using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14.Core;

public class Animal
{
    private string name;

    public string Type { get; }

    public string Name {
        get
        {
            Console.WriteLine("Changed Logic");
            return name;
        }
        set
        {
            this.name = value;
        }
    }

    public Animal(string name, string type)
    {
        Type = type;
        Name = name;
    }

    public string GetFullName()
    {
        return $"Animal {Name} with type {Type}";
    }
}
