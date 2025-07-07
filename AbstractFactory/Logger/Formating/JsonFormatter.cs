namespace AbstractFactory.Logger.Formating;

public class JsonFormatter : IFormatter
{
    public string Format(string text)
    {
        return $"{{ \"timestamp\" : {DateTime.Now}, \"message\" : {text} }}";
    }
}