using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12;

internal static class MathHelper
{
    public static double Pi = 3.14;

    public static int Square(int number)
    {
        return number * number;
    }

    public static int Factorial(int n)
    {
        // n = 5;
        // 1 * 2 * 3 * 4 * 5;

        if (n <= 1)
        {
            return 1;
        }
        
        int temp = Factorial(n - 1);

        return n * temp;
    }
}
