﻿using System;
using System.Linq.Expressions;

namespace FluentAssertions.Formatting;

public class ExpressionValueFormatter : IValueFormatter
{
    /// <summary>
    /// Indicates whether the current <see cref="IValueFormatter"/> can handle the specified <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The value for which to create a <see cref="string"/>.</param>
    /// <returns>
    /// <see langword="true"/> if the current <see cref="IValueFormatter"/> can handle the specified value; otherwise, <see langword="false"/>.
    /// </returns>
    public bool CanHandle(object value)
    {
        return value is Expression;
    }

    public void Format(object value, FormattedObjectGraph formattedGraph, FormattingContext context, FormatChild formatChild)
    {
        formattedGraph.AddFragment(value.ToString().Replace(" = ", " == ", StringComparison.Ordinal));
    }
}
