namespace Lesson7;

internal class Program
{
    static void Main(string[] args)
    {
        var result = ConvertInchesToCm_1(10);
        Console.WriteLine(result);
    }

    static double ConvertInchesToCm_1(int inches)
    {
        const double inchToCm = 2.54;
        return inches * inchToCm;
    }

    static void GenerateAndPrintRandomNumbers_2()
    {
        Random random = new Random();
        Console.WriteLine("Випадкові числа:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(random.Next(1, 101));
        }
    }

    static void FindNumbersWithSquareSumDivisibleBy13_3()
    {
        Console.WriteLine("Числа, сума квадратів цифр яких ділиться на 13:");

        for (int i = 10; i < 100; i++)
        {
            int digit1 = i / 10;
            int digit2 = i % 10;
            int sumOfSquares = (digit1 * digit1) + (digit2 * digit2);

            if (sumOfSquares % 13 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Calculator4()
    {
        while (true)
        {
            Console.Write("Введіть перше число: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                break;
            }

            Console.Write("Введіть операцію (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Введіть друге число: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                break;
            }

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Помилка: Ділення на нуль!");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Невідома операція!");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Результат: {result}");
            }

            Console.WriteLine("Натисніть Enter для продовження або іншу клавішу для виходу...");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                break;
            }
            Console.WriteLine();
        }
    }

    static void CalculateAndDisplayFinalAmount6()
    {
        // Введення початкової суми вкладу та кількості місяців
        Console.Write("Введіть суму вкладу: ");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введіть кількість місяців: ");
        int months = Convert.ToInt32(Console.ReadLine());

        decimal interestRate = 0.07m; // 7% відсотків на місяць

        // Цикл для нарахування відсотків кожного місяця
        for (int i = 1; i <= months; i++)
        {
            deposit += deposit * interestRate; // Нарахування відсотків
        }

        // Виведення результату
        Console.WriteLine($"{Environment.NewLine}Кінцева сума вкладу після {months} місяців: {deposit:F2} грн.");
    }
    static void MultiplyNumbers7()
    {
        while (true)
        {
            Console.Write("Введіть перше число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber >= 0 && firstNumber <= 10 && secondNumber >= 0 && secondNumber <= 10)
            {
                int result = firstNumber * secondNumber;
                Console.WriteLine($"Результат множення: {result}");
                break;
            }
            else
            {
                Console.WriteLine("Неприпустимі числа. Введіть числа в діапазоні від 0 до 10.");
            }
        }
    }
}
