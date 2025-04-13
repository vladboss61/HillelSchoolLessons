using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14.Core;

public class Animal
{
    public string Type { get; set; }

    public string Name { get; set; }

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
