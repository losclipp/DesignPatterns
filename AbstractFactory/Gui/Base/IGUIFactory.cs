namespace AbstractFactory.Gui.Base;

public interface IGuiFactory
{
    IButton CreateButton();
    ICheckBox CreateCheckBox();
    ITextField CreateTextField();
}