using System;

namespace Lesson12;

internal class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();
        var res = calculator.Add(10, 20);
        Main(args);
        Console.WriteLine("Hello, World!");
    }

    // Overloaded
    public void PrintMessage(string message = "Default message")
    {
        Console.WriteLine(message);
    }

    // Overloaded
    public void PrintMessage(string message, int repeatCount)
    {
        for (int i = 0; i < repeatCount; i++)
        {
            Console.WriteLine(message);
        }
    }

    public void PrintNumbers(params int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public void Increment(ref int number)
    {
        number++;
    }

    public void GetValues(out int number, out string text)
    {
        number = 42;
        text = "Hello";
    }
}
