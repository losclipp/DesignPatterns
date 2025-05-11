using AbstractFactory.Gui.Base;

namespace AbstractFactory.Gui.Windows;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Windows Button has been rendered.");
    }

    public void Click()
    {
        Console.WriteLine("Windows Button has been clicked.");
    }
}