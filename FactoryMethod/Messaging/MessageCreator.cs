namespace FactoryMethod.Messaging;

public abstract class MessageCreator
{
    public abstract IMessage CreateMessage();
}