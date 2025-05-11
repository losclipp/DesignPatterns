using AbstractFactory.Gui.Base;

namespace AbstractFactory.Gui.Mac;

public class MacTextField : ITextField
{
    public void Render()
    {
        Console.WriteLine("MacTextField has been rendered.");
    }

    public string Text { get; set; }
}