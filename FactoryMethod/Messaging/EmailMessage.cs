namespace FactoryMethod.Messaging;

public class EmailMessage : IMessage
{
    public void Send(string message)
    {
        Console.WriteLine($"Email Sending: {message}.");
    }
}