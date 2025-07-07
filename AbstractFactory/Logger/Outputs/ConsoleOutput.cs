namespace AbstractFactory.Logger.Outputs;

public class ConsoleOutput : IOutput, IDisposable
{
    public Task Message(string message)
    {
        Console.WriteLine(message);
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        
    }
}