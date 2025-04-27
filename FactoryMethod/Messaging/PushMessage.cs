namespace FactoryMethod.Messaging;

public class PushMessage : IMessage
{
    public void Send(string message)
    {
        Console.WriteLine($"Push Sending: {message}.");

    }
}