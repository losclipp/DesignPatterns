namespace FactoryMethod.Buttons;

public class HTMLButton : IButton
{
    public void Render()
    {
        Console.WriteLine("HTML button is rendering...");
    }
}