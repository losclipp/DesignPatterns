namespace FactoryMethod.Messaging;

public class SMSMessage: IMessage
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS Sending: {message}.");

    }
}