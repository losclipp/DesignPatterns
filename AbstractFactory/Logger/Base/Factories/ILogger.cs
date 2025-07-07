namespace AbstractFactory.Logger.Base;

public interface ILogger : IDisposable
{
    Task LogAsync(string message);
}