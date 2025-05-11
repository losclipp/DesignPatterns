using AbstractFactory.Gui.Base;

namespace AbstractFactory.Gui.Windows;

public class WindowsCheckBox : ICheckBox
{
    
    private bool _isChecked = false;

    public void Render()
    {
        Console.WriteLine("Windows CheckBox has been rendered.");
    }

    public bool IsChecked => _isChecked;

    public void Check(bool value)
    {
       _isChecked = value;
    }
}