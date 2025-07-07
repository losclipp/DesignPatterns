namespace AbstractFactory.Logger.Abstraction;

public interface ILogger : IDisposable
{
    Task LogAsync(string message);
}