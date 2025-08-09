namespace Adapter.Logger;

public class LegacyJsonLogger
{
    public void Write(LegacyLoggerData message)
    {
        Console.WriteLine($"severity: {message.Severity}");
        Console.WriteLine($"message: {message.Message}");
        Console.WriteLine($"meta: {message.Meta}");
    }
}