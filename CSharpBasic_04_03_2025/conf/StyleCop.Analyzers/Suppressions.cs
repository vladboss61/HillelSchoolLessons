﻿// Copyright 2025 Hillel. All rights reserved.
// This source code file.

using System.Diagnostics.CodeAnalysis;

// Template Version: 1.0.0 (2025-01-01)

// Enable the SX1101 rule and delete this suppression as soon as
// UI tooling support for code analysis rule sets is added to
// Microsoft Visual Studio.
[assembly: SuppressMessage(
    "StyleCop.CSharp.ReadabilityRules",
    "SA1101:Prefix local calls with this",
    Justification = "Contradicts the established coding style.")]

// Enable the SX309 rule and delete this suppression as soon as
// UI tooling support for code analysis rule sets is added to
// Microsoft Visual Studio.
[assembly: SuppressMessage(
    "StyleCop.CSharp.NamingRules",
    "SA1309:Field names must not begin with underscore",
    Justification = "Contradicts the established coding style.")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.ReadabilityRules",
    "SA1118:Parameter must not span multiple lines",
    Justification = "Contradicts the established coding style.")]
[assembly: SuppressMessage(
    "StyleCop.CSharp.MaintainabilityRules",
    "SA1407:Arithmetic expressions must declare precedence",
    Justification = "Contradicts the established coding style.")]
[assembly: SuppressMessage(
    "StyleCop.CSharp.MaintainabilityRules",
    "SA1408:Conditional expressions must declare precedence",
    Justification = "Contradicts the established coding style.")]
[assembly: SuppressMessage(
    "StyleCop.CSharp.ReadabilityRules",
    "SA1413:Use trailing comma in multi-line initializers",
    Justification = "Contradicts the established coding style.")]
