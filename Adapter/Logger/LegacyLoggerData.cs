namespace Adapter.Logger;

public class LegacyLoggerData
{
    // 0 = info, 1 = warn, 2 = error
    public int Severity { get; set; }
    public string? Message { get; set; }
    public object? Meta { get; set; }
}