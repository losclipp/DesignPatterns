namespace AbstractFactory.Logger.Formating;

public class TextFormatter : IFormatter
{
    public string Format(string text)
    {
        return $"{DateTime.Now}: {text}";
    }
}