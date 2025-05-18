// Copyright 2025 Hillel. All rights reserved.
// This source code file.

namespace Lesson1;

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

/// <summary>
///     Switch localization culture.
/// </summary>
public sealed class LocalizationSwitch
{
    private readonly string _currentCulture;

    /// <summary>
    ///     Initializes a new instance of the <see cref="LocalizationSwitch"/> class.
    /// </summary>
    /// <param name="culture">Culture.</param>
    public LocalizationSwitch(string culture)
    {
        _currentCulture = culture;
    }

    /// <summary>
    ///     Executes action on switched culture.
    /// </summary>
    /// <param name="action">Action.</param>
    public void Execute(Action action)
    {
        CultureInfo prevCulture = Thread.CurrentThread.CurrentCulture;
        CultureInfo prevUICulture = Thread.CurrentThread.CurrentUICulture;
        CultureInfo currentCulture = new CultureInfo(_currentCulture);
        try
        {
            Thread.CurrentThread.CurrentCulture = currentCulture;
            Thread.CurrentThread.CurrentUICulture = currentCulture;

            action();
        }
        finally
        {
            Thread.CurrentThread.CurrentCulture = prevCulture;
            Thread.CurrentThread.CurrentUICulture = prevUICulture;
        }
    }
}
