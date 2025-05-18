// Copyright 2025 Hillel. All rights reserved.
// This source code file.

namespace Lesson1;

using System;
using System.Globalization;
using System.Resources;
using System.Threading;

/// <summary>
///     Switch localization culture.
/// </summary>
public sealed class LocalizationSwitch
{
    private readonly CultureInfo _currentCulture;
    private readonly ResourceManager _resourceManager;

    /// <summary>
    ///     Initializes a new instance of the <see cref="LocalizationSwitch"/> class.
    /// </summary>
    /// <param name="resourceManager">Resource manager.</param>
    /// <param name="culture">Culture.</param>
    public LocalizationSwitch(ResourceManager resourceManager, string culture)
    {
        _resourceManager = resourceManager;
        _resourceManager.IgnoreCase = true;
        _currentCulture = new CultureInfo(culture);
    }

    /// <summary>
    ///     Gets localized string indexer.
    /// </summary>
    /// <param name="keyName">Localization key name.</param>
    /// <returns>localized string.</returns>
    public string this[string keyName]
    {
        get => GetString(keyName);
    }

    /// <summary>
    ///     Executes action on switched culture.
    /// </summary>
    /// <param name="action">Action.</param>
    public void Execute(Action action)
    {
        SwitchCulture(action);
    }

    /// <summary>
    ///     Executes action on switched culture with resource manager.
    /// </summary>
    /// <param name="action">Action.</param>
    public void Execute(Action<ResourceManager> action)
    {
        SwitchCulture(() => action(_resourceManager));
    }

    /// <summary>
    ///     Gets localized string.
    /// </summary>
    /// <param name="keyName">Localization key name.</param>
    /// <returns>localized string.</returns>
    public string GetString(string keyName)
    {
        return _resourceManager.GetString(keyName, _currentCulture);
    }

    private void SwitchCulture(Action action)
    {
        CultureInfo prevCulture = Thread.CurrentThread.CurrentCulture;
        CultureInfo prevUICulture = Thread.CurrentThread.CurrentUICulture;
        CultureInfo currentCulture = _currentCulture;
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
