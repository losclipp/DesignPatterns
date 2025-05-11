namespace FactoryMethod.Messaging;

public class PushCreator : MessageCreator
{
    public override IMessage CreateMessage()
    {
        return new PushMessage();
    }
}