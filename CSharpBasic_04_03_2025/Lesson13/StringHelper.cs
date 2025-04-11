using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13;
internal class StringHelper
{
    public static string Reverse(string str)
    {
        char[] reversed = new char[str.Length];
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed[i] = str[i];
        }

        return new string(reversed);
    }
}
