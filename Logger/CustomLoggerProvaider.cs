
using Microsoft.Extensions.Logging;

namespace BlazorWASM.Logger;
public class CustomLoggerProvaider : ILoggerProvider
{
#region Implementation of IDisposable

    /// <inheritdoc />
    public void Dispose()
    {
        
    }

    /// <inheritdoc />
    public ILogger CreateLogger(string categoryName) => new CustomLogger();

#endregion
}
