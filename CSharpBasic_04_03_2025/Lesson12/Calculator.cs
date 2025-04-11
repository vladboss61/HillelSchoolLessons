using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12;


public class CalculatorResult
{
    public int Result;

    public string InformationMessage;
}


public class Calculator
{
    public CalculatorResult Add(int a, int b)
    {
        int result = a + b;

        //CalculatorResult calculatorResult = new CalculatorResult()
        //{
        //    Result = result,
        //    InformationMessage = $"This is successful a + b = {result} calculation. "
        //};

        // Теж саме що й зверху.
        CalculatorResult calculatorResult = new CalculatorResult();

        calculatorResult.Result = result;
        calculatorResult.InformationMessage = $"This is successful a + b = {result} calculation. ";

        return calculatorResult;
    }

    public void Print(int number)
    {
        if (number > 50)
        {
            return;
        }

        Console.WriteLine($"Print is executed:  {number}");
    }
}
