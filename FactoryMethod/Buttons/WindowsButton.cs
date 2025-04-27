namespace FactoryMethod.Buttons;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Windows button is rendering...");
    }
}