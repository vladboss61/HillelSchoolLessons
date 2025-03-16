using System.Text;

namespace Lesson4;

internal class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        int z = x + y + x * (10);

        int y1 = -y;
        int y2 = +y1;

        int i = 1;

        int x1 = 1;//i++ + ++i;

        int x2 = 2;

        int x3 = x2 = x1;

        i++; // i = i + 1;
        ++i; // i = i + 1;

        i--; // i = i - 1;
        --i; // i = i - 1;

        int result1 = 0;
        int calculation1 = 2 + result1++; // calculation = 2 + result = result + 1 ==  2 + result++
        Console.WriteLine(calculation1);

        int result2 = 0;

        int calculation2 = 2 + ++result2; // calculation2 = 2 + (result = result + 1) ==  2 + ++result
        Console.WriteLine(calculation2);

        // Change OutputEncoding with Unicode for console output strings. (Support Ukraine strings)
        Console.OutputEncoding = Encoding.Unicode;
        // Change InputEncoding with Unicode for user input from console. (Support Ukraine strings)
        Console.InputEncoding = Encoding.Unicode;

        int number = 255;
        byte @byte = (byte)number; // 8 bit 0000 0001


        int shitRight = 6;
        // 3 == 0000 0110

        int res = shitRight >> 2; // 0000 0110 >> 2 => 0000 0001;
        int res2 = shitRight << 1; // 0000 0110 << 1 => 0000 1100;
        int res3 = shitRight << 2; // 0000 0110 << 2 => 0001 1000;

        // 0000 0000 = 0
        // 0000 0001 = 1
        // 0000 0010 = 2
        // 0000 0011 = 3
        // 0000 0100 = 4
        // 0000 0101 = 5
        // 0000 0110 = 6
        // 0000 0111 = 7
        // 0000 1000 = 8
        // 1111 1111 = 255
        //1 0000 0000 = 256

        int leftNumber = 4;
        int rightNumber = 57;
        int response = leftNumber | rightNumber;

        Console.WriteLine(response);
        // 0000 0001
        //&

        // 0000 0100 == 4
        //|
        // 0011 1001 == 57
        // 0011 1101

        int test = 5;
        int added = 6;
        test += added;
        test -= added; //test = test - added;

        Console.WriteLine($"Byte in HEX: {@byte.ToString("X2")}"); // byte в Hexadecimal (Шістнадцяткова) система
        Console.WriteLine($"Byte in Binary: {Convert.ToString(@byte, 2).PadLeft(8, '0')}"); // byte в binary (Двійкова) система

        short @short = 256; // 16 bit = 2 byte
        // 0000 0000 0000 0000

        Console.WriteLine($"Short in HEX: {@short.ToString("X2")}"); // short в Hexadecimal (Шістнадцяткова) система
        Console.WriteLine($"Short in Binary: {Convert.ToString(@short, 2).PadLeft(16, '0')}"); // short  в binary (Двійкова) система

        int @int = 73612231; // 32 bit
        //1 1111 1111 1111 1111 1111 1111 1111 1111 299832109381290312
        Console.WriteLine($"Int in HEX: {@int.ToString("X2")}"); // int в Hexadecimal (Шістнадцяткова) система
        Console.WriteLine($"Int in Binary: {Convert.ToString(@int, 2).PadLeft(32, '0')}"); // int в binary (Двійкова) система

        bool @bool1 = true; //0000 0000
        bool @bool2 = false; // 0000 0001

        //bool isCorrectResult = number1 != number2;

        int number1 = 11;
        int number2 = 10;
        int number3 = 9;

        if (number1 <= number2)
        {
            Console.WriteLine("number1 меньше number2 або дорівнює");
        }
        else if(number2 <= number3)
        {
            Console.WriteLine("number2 меньше number3 або дорівнює");
        }
        else
        {
            Console.WriteLine("[нічого що будло вище]");
        }

        Random rand = new Random();

        number = rand.Next(0, 10);

        switch (number)
        {
            case 0:
                Console.WriteLine("I got 0");
                break;
            case 1:
                Console.WriteLine("I got 1");
                break;
            case 5:
                Console.WriteLine("I got 5");
                break;
            case 6:
                Console.WriteLine("I got 5");
                break;
            default:
                Console.WriteLine("Nothing");
                break;
        }

        string color = "blue";

        if(color == "red")
        {

        }
        else if(color == "blue")
        {

        }
        else if (color == "yellow")
        {

        }
        else
        {

        }
            
        switch (color)
        {
            case "red" or "blue":
                Console.WriteLine("It is red or blue color");
                break;
            case "yellow":
                Console.WriteLine("It is yellow color");
                break;
            default:
                Console.WriteLine("I do know the color");
                break;
        }


        bool isRainOutside = true;
        bool shouldTakeUmbrella = false;

        if (isRainOutside && shouldTakeUmbrella) // true && false => false
        {
            Console.WriteLine("Ти будеш сухий");
        }

        string country = "Poland";
        int age = 18;
        bool hasDrivingLicense = false;
        bool testDriver = true;
        bool availableToDrive = age >= 18 || hasDrivingLicense;

        switch (country)
        {
            case "England":
                if (age >= 18 && hasDrivingLicense)
                {
                    Console.WriteLine("Можеш сідати за кермо в Англії");
                }
                else
                {
                    Console.WriteLine("не можно водити машину в Англії");
                }
                break;
            case "Estonia":
                if (age >= 16 && hasDrivingLicense)
                {
                    Console.WriteLine("Можеш сідати за кермо в Естонії");
                }
                else
                {
                    Console.WriteLine("не можно водити машину в Естонії");
                }
                break;
            case "Poland":
                if ((age >= 17 && hasDrivingLicense) || testDriver)
                {
                    Console.WriteLine("Можеш сідати за кермо в Poland");
                }
                else
                {
                    Console.WriteLine("не можно водити машину в Poland");
                }
                break;
            default:
                break;
        }
    }

    public static string GetBinaryRepresentation(long number, int countBits)
    {
        return $"Byte in Binary: {Convert.ToString(number, 2).PadLeft(countBits, '0')}";
    }

    public static string GetHexadecimalRepresentation(long number)
    {
        return $"Byte in HEX: {number.ToString("X2")}";
    }
}
