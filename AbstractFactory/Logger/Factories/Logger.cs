using AbstractFactory.Logger.Abstraction;
using AbstractFactory.Logger.Formating;
using AbstractFactory.Logger.Outputs;

namespace AbstractFactory.Logger.Factories;

public class Logger : ILogger, IDisposable
{
    private readonly IFormatter _formatter;
    private readonly IOutput _output;
    
    public Logger(IFormatter formatter, IOutput output)
    {
        _formatter  = formatter;
        _output = output;
    }
    
    public async Task LogAsync(string message)
    {
        await _output.Message(_formatter.Format(message));
    }

    public void Dispose()
    {
        _output.Dispose();
    }
}