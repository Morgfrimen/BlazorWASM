
using System;

using Microsoft.Extensions.Logging;

namespace BlazorWASM.Logger;
public class CustomLogger :ILogger
{
#region Implementation of ILogger

    /// <inheritdoc />
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception,
                            Func<TState, Exception?, string> formatter)
    {
        string str = $"{logLevel}+{eventId.Name}+{state}+{exception?.Message}";
        Console.WriteLine(str);
    }

    /// <inheritdoc />
    public bool IsEnabled(LogLevel logLevel) => true;

    /// <inheritdoc />
    public IDisposable BeginScope<TState>(TState state) => default;

#endregion
}
