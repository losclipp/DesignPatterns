namespace AbstractFactory.Gui.Base;

public interface ITextField
{
    void Render();
    string Text { get; set; }
}