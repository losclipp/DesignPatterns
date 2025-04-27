namespace FactoryMethod.Buttons;

public class WindowsDialog : Dialog
{
    public override IButton CreateButton()
    {
        return new WindowsButton();
    }
}