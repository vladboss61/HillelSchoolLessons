using System;
using System.Text;

namespace Lesson2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("==========================");

            // Changing Output.
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //const double PI = 3.14159;

            char ch = '7';

            Console.Write("Char: ");
            Console.WriteLine((int)ch);

            string strA = "aasdadasdsadssd";
            float floatData = 125.25f;
            double doubleData = 125.25123;

            Console.WriteLine((decimal)(43.65 + 61.11));

            Console.WriteLine("FloatData: " + floatData);
            Console.WriteLine("DoubleData: " + doubleData);

            MyFunc();

            Console.WriteLine("==========================");

            // =
            // ==

            // Variables

            string name = "Vlad";

            string lastName = " Varvashenko";
            string nameAndLastName = name + lastName;

            Console.WriteLine(nameAndLastName);
            Console.WriteLine(name + lastName);

            name = "Jon";
            Console.WriteLine(name);

            Console.WriteLine("==========================");

            int myVariable = 10;

            Console.Write("My Variable: ");
            Console.WriteLine(myVariable);

            int sum = myVariable + 30;
            Console.Write("My Sum: ");
            Console.WriteLine(sum);

            var age = "27"; // int age = 0;

            //int age = 25, height = 180, weight = 75;

            Console.Write("My Age: ");
            Console.WriteLine(age);

            Console.WriteLine("Hello, World!");

            Console.WriteLine("==========================");

            // Boolean / bool

            bool isWinter = false;
            bool isSpring = true;

            Console.WriteLine("isWinter: " + isWinter);
            Console.WriteLine("isSpring: " + isSpring);

            string pet = "Bulldog";

            bool isPetNameLong = pet.Length > 5;

            if (isPetNameLong)
            {
                Console.WriteLine("Pet Name is long: " + isPetNameLong);
            }

            Console.WriteLine("==========================");
            // String formatting.

            string myName = "Vlad";
            string myLastName = "Varvasheko";

            string output1 = myName + " " + myLastName + " " + "Hello World";
            Console.WriteLine(output1);

            string output2 = $"| {myName} | {myLastName} | Hello World";
            Console.WriteLine(output2);

            Console.WriteLine("| {0} | {0} | {1} | Hello World", myName, myLastName);

            var output3 = string.Format("| {0} | {0} | {1} | Hello World", myName, myLastName);
            Console.WriteLine(output3);

            Console.WriteLine("==========================");

            // Working with console.

            /*
             Hello my name Vlad
             I put several lines comments.
             */

            Console.Write("Введіть ваше ім'я: ");
            string nameFromConsole = Console.ReadLine();

            Console.WriteLine($"Ваше ім'я: {nameFromConsole}");

            Console.Write("Введіть вашу фамілію: ");
            string lastNameFromConsole = Console.ReadLine();

            Console.WriteLine($"Ваша фамілія: {lastNameFromConsole}");

            Console.Write($"Скільки Вам років: ");

            string ageFromConsole = Console.ReadLine();
            Console.WriteLine($"Мені років: {ageFromConsole}");

            Console.WriteLine($"Ваші данні: Ім'я - {nameFromConsole}, Фамілія - {lastNameFromConsole}, Вік: {ageFromConsole}");

            Console.WriteLine("==========================");

            Console.WriteLine("Калькулятор");

            Console.Write("Введіть х: ");

            string xString = Console.ReadLine();
            double x = Convert.ToDouble(xString);

            Console.Write("Введіть y: ");
            string yString = Console.ReadLine();

            double y = Convert.ToDouble(yString);

            Console.WriteLine("Помилка: " + xString + yString);
            Console.WriteLine($"Сума х + у = {x + y}");

            Console.WriteLine("==========================");

            // Пряма конвертація. long може
            // зберігати будь-яке значення, яке може містити int, і більше!
            int num = 2117483311;
            long bigNum = num;
            Console.WriteLine(bigNum);
            
            float floatNumber = 239113.000f;
            double doubleNumber = floatNumber;

            long longNumber = 99999;
            int castInt = (int)longNumber;

            Console.WriteLine(castInt);
        }

        static void MyFunc()
        {
            Console.WriteLine("Hello My Func");
        }
    }
}
