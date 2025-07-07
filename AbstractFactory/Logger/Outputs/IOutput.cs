namespace AbstractFactory.Logger.Outputs;

public interface IOutput : IDisposable
{
    Task Message(string message);
}