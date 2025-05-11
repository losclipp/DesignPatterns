using AbstractFactory.Gui.Base;

namespace AbstractFactory.Gui.Windows;

public class WindowsFactory : IGuiFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckBox CreateCheckBox()
    {
        return new WindowsCheckBox();
    }

    public ITextField CreateTextField()
    {
        return new WindowsTextField();
    }
}