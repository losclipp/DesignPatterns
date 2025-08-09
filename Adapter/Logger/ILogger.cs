namespace Adapter.Logger;

public interface ILogger
{
    void Log(LogLevel level, string? message, IDictionary<string, object>? context = null);
}