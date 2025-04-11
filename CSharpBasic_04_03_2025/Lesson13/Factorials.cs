using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13;
internal class Factorials
{
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

    public static int FactorialiIteratively(int n)
    {
        int result = 1;

        for (int i = 0; i < n; i++)
        {
            result = result * i;
        }

        return result;
    }
}
