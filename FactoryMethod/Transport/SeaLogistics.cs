namespace FactoryMethod;

public class SeaLogistics : Logistic
{
    public override Transport CreateTransport()
    {
        return new Ship();
    }
}