namespace FactoryMethod.Messaging;

public class EmailCreator : MessageCreator
{
    public override IMessage CreateMessage()
    {
        return new EmailMessage();
    }
}