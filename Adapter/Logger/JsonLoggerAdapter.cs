namespace Adapter.Logger;

public class JsonLoggerAdapter : ILogger
{
    
    private readonly LegacyJsonLogger _legacyJsonLogger;

    public JsonLoggerAdapter(LegacyJsonLogger legacyLogger)
    {
        _legacyJsonLogger = legacyLogger;
    }
    public void Log(LogLevel level, string? message, IDictionary<string, object>? context = null)
    {
        if (string.IsNullOrEmpty(message))
         throw new ArgumentNullException(nameof(message));

        var severity = -1;

        switch (level)
        {
            case LogLevel.Info:
            {
                severity = 0;
                break;
            }
            case LogLevel.Warn:
            {
                severity = 1;
                break;
            }
            case LogLevel.Error:
            {
                severity = 2;
                break;
            }
            default:
            {
                throw new ArgumentOutOfRangeException(nameof(level), level, null);
            }
        }

       
        _legacyJsonLogger.Write(new LegacyLoggerData
        {
            Severity = severity,
            Message = message,
            Meta = context,
        });
    }
}