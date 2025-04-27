namespace FactoryMethod.Messaging;

public class SMSCreator : MessageCreator
{
    public override IMessage CreateMessage()
    {
        return new SMSMessage();
    }
}