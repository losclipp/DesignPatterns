namespace FactoryMethod.Buttons;

public class WebDialog : Dialog
{
    public override IButton CreateButton()
    {
        return new HTMLButton();
    }
}