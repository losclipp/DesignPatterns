namespace AbstractFactory.Gui.Base;

public interface ICheckBox
{
    void Render();
    bool IsChecked { get; }
    void Check(bool value);
}