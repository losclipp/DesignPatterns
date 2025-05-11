using AbstractFactory.Gui.Base;

namespace AbstractFactory.Gui.Mac;

public class MacCheckBox :  ICheckBox
{
    private bool _checked = false;
    public void Render()
    {
        Console.WriteLine("MacCheckBox has been rendered.");
    }

    public bool IsChecked => _checked;

    public void Check(bool value)
    {
        _checked = value;
    }
}