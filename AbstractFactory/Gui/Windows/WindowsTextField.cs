using AbstractFactory.Gui.Base;

namespace AbstractFactory.Gui.Windows;

public class WindowsTextField : ITextField
{
    public void Render()
    {
        Console.WriteLine("Windows TextField has been rendered.");
    }

    public string Text { get; set; }
}