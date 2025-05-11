using AbstractFactory.Gui.Base;

namespace AbstractFactory.Gui.Mac;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("MacButton has been rendered.");
    }

    public void Click()
    {
        Console.WriteLine("MacButton has been clicked.");
    }
}