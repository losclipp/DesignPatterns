namespace FactoryMethod;

public class RoadLogistics : Logistic
{
    public override Transport CreateTransport()
    {
        return new Truck();
    }
}