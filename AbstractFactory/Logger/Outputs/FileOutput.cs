namespace AbstractFactory.Logger.Outputs;

public class FileOutput : IOutput, IDisposable
{
    private readonly StreamWriter _writer;
    
    public FileOutput(string filePath)
    {
        _writer = new StreamWriter(filePath, true);
    }

    public Task Message(string message)
    {
        return _writer.WriteLineAsync(message);
    }

    public void Dispose()
    {
        _writer.Dispose();
    }
}