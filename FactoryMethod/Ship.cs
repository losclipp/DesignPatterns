namespace FactoryMethod;

public class Ship : Transport
{
    public void Deliver()
    {
        Console.WriteLine("Ship Delivering");
    }
}