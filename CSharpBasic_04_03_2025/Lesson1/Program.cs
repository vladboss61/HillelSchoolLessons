// Copyright 2025 Hillel. All rights reserved.
// This source code file.

namespace Lesson1;

using System;

/// <summary>
///     Start point.
/// </summary>
internal class Program
{
    /// <summary>
    ///     Main.
    /// </summary>
    /// <param name="args">Args.</param>
    public static void Main(string[] args) {
        // Comment in CSharp.
        // PascalCase

        // https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names

        // camelCase

        // int aget = 1033123;

        // double weight1 = 100.10;
        // float weight2 = 100.10;

        // bool isWinter = false;
        // bool isSpring = true;
        string firstName = "Vlad";
        string lastName = "Varvashenko";

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);

        Console.WriteLine("Hello, World!");
    }

    /// <summary>
    ///     SimpleFunction.
    /// </summary>
    private static void SimpleFunction()
    {
        Console.WriteLine("Hello Simple Function/Method");
    }
}
