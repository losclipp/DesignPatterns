using AbstractFactory.Gui.Base;

namespace AbstractFactory.Gui.Mac;

public class MacFactory : IGuiFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckBox CreateCheckBox()
    {
        return new MacCheckBox();
    }

    public ITextField CreateTextField()
    {
        return new MacTextField();
    }
}