using System.Text;

namespace Builder.House;

public class House
{
    public House()
    {
        Walls = new List<string>();
        Doors = new List<string>();
        Windows = new List<string>();
    }
    public IList<string> Walls { get; set; }
    public string? Roof { get; set; }
    public IList<string> Doors { get; set; }
    public IList<string> Windows { get; set; }
    public string? Base { get; set; }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Base: {Base}");
        stringBuilder.AppendLine($"Roof: {Roof}");
        stringBuilder.Append($"Doors: ");
        foreach (var door in Doors)
        {
            stringBuilder.Append($"{door}, ");
        }

        stringBuilder.AppendLine();
        stringBuilder.Append($"Walls: ");
        foreach (var wall in Walls)
        {
            stringBuilder.Append($"{wall}, ");
        }
        stringBuilder.AppendLine();
        stringBuilder.Append($"Windows: ");
        foreach (var window in Windows)
        {
            stringBuilder.Append($"{window}, ");
        }
        
        return stringBuilder.ToString();
    }
}