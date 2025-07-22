using System.Collections.Specialized;
using System.Text;

namespace Builder.HTML;

public class HTMLBuilder
{
    class Element
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public IDictionary<string, string> Attributes { get; set; }
    }
    
    private IList<Element> _elements = new List<Element>();

    private void AddElement(string name, string content = null, IDictionary<string, string> attributes = null)
    {
        var element = new Element();
        element.Name = name;
        if (content != null) element.Content = content;
        if (attributes != null)
        {
            element.Attributes = new Dictionary<string, string>();
            foreach (var attribute in attributes)
            {
                element.Attributes.Add(attribute.Key, attribute.Value);
            }
        }
        _elements.Add(element);
   
    }

    public HTMLBuilder AddHeader(int headerSize, string content)
    {
        if (headerSize < 1 || headerSize > 6) throw new ArgumentOutOfRangeException("headerSize");
        
        AddElement($"h{headerSize}", content);
        return this;
    }

    public HTMLBuilder AddParagraph(string content)
    {
        AddElement("p", content);
        return this;
    }

    public HTMLBuilder AddImage(string source, string alternate)
    {
        var attributes = new Dictionary<string, string>
        {
            { "src", source },
            { "alt", alternate }
        };
        AddElement("img", attributes: attributes);
        return this;
    }

    public string Build()
    {
        var result = new StringBuilder();
        DefaultInitialization(result);

        foreach (var element in _elements)
        {
            result.AppendLine();
            result.Append($"<{element.Name}");
            if (element.Attributes != null && element.Attributes.Count > 0)
            {
                foreach (var attribute in element.Attributes)
                {
                    result.Append($" {attribute.Key}=\"{attribute.Value}\"");
                }
            }

            result.Append(">");
            if (element.Content != null) 
                result.Append(element.Content);
            
            result.Append($"</{element.Name}>");
        }
        
        DefaultEnd(result);
        
        
        return result.ToString();

    }

    private void DefaultInitialization(StringBuilder stringBuilder)
    {
        stringBuilder.AppendLine(@"<!DOCTYPE html>");
        stringBuilder.AppendLine(@"<html>");
        stringBuilder.AppendLine(@"<head>");
        stringBuilder.AppendLine("""<meta charset="utf-8">""");
        stringBuilder.AppendLine("""<meta name="viewport" content="width=device-width, initial-scale=1.0">""");
        stringBuilder.AppendLine(@"<title>Document</title>");
        stringBuilder.AppendLine(@"</head>");
        stringBuilder.AppendLine(@"<body>");
    }

    private void DefaultEnd(StringBuilder stringBuilder)
    {
        stringBuilder.AppendLine();
        stringBuilder.AppendLine(@"</body>");
        stringBuilder.AppendLine(@"</html>");
    }
}