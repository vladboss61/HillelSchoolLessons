using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13;

internal static class MathHelp
{
    public static class InnerClass
    {
        public static void Update()
        {
        }
    }

    public static int Sum(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    //public static void Swap<TInput>(ref TInput a, ref TInput b)
    //{
    //    TInput temp = a;
    //    a = b;
    //    b = temp;
    //}
}
