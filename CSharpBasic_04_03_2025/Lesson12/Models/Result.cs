using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12.Models;
public class Result
{
    public int Number { get; set; }
    public string Text { get; set; }

    public static Result GetValues()
    {
        return new Result { Number = 42, Text = "Hello" };
    }
}
