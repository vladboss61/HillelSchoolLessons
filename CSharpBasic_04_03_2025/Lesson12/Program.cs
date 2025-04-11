using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Lesson12;

internal class Program
{
    static void Main(string[] args)
    {
        int factorial5 = MathHelper.Factorial(5);
        var squareNumber = MathHelper.Square(5);
        var program = new Program();

        //program.PrintMessage();
        //program.PrintMessage(999);
        //program.PrintMessage(number: 999, message: "This is long message");
        //program.PrintMessage(999, "Hello my function");
        //int[] numbers = [1, 10, 20, 66];
        //program.PrintArray(numbers);
        //program.PrintNumbers(10, 20, 30, 40, 56);
        //program.PrintStrings("Vlad", "Den", "Pen");
        //program.PrintStrings(["Vlad", "Den", "Pen"]);

        program.PrintMessage();
        program.PrintMessage("Hello Overload Function", 5);

        int i = 10;

        //int number = i;

        program.IncrementNoRef(i);
        Console.WriteLine(i);

        
        program.Increment(ref i);
        Console.WriteLine(i);

        //int number;
        //string text;
        //program.GetValues(out number, out text);

        program.GetValues(out int number, out string text);

        Console.WriteLine(number);
        Console.WriteLine(text);

        var calculator = new Calculator();

        CalculatorResult res1 = calculator.Add(10, 20);
        CalculatorResult res2 = calculator.Add(20, 50);

        calculator.Print(20);
        calculator.Print(59);

        Console.WriteLine(res1.Result);
        Console.WriteLine(res1.InformationMessage);

        Console.WriteLine();
        
        Console.WriteLine(res2.Result);
        Console.WriteLine(res2.InformationMessage);

        Console.WriteLine("Hello, World!");
    }


    public void LambdaExample()
    {
        Action<string> func = (string str) =>
        {
            Console.WriteLine($"Hello Lambda. {str}");
        };

        //var monsterExecuted = monster()()();

        //Enumerable.Range(0, 10).Where((x) => x > 5);

        //Func<string> func2 = string () =>
        //{
        //    return "Not so long text";
        //};

        //var monster = () => () => () => 10;
        //var monsterExecuted = monster()()();

        Func<string> func2 = string () => "Not so long text";

        Console.WriteLine("Other Code");

        func("Ohhh so complex example....");

        string textFromFunc2 = func2();

        Console.WriteLine(textFromFunc2);
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

    public void PrintArray(int[] numbers)
    {
        Console.WriteLine("Print Array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public void PrintNumbers(params int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public void PrintStrings(params string[] strs)
    {
        foreach (string str in strs)
        {
            Console.WriteLine(str);
        }
    }

    public void IncrementNoRef(int number)
    {
        number++;
    }

    public void Increment(ref int number)
    {
        number = number + 1;
    }

    public void GetValues(out int number, out string text)
    {
        number = 42;
        text = "Hello";
    }
}
