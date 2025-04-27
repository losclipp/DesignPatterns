namespace FactoryMethod.Messaging;

public class MessageFactory
{
    public MessageCreator GetCreator(MessageType messageType) => messageType switch
    {
        MessageType.Email => new EmailCreator(),
        MessageType.Push => new PushCreator(),
        MessageType.Sms => new SMSCreator(),
        _ => throw new ArgumentOutOfRangeException(nameof(messageType), $"Not valid MessageType: {messageType}"),

    };
}
    