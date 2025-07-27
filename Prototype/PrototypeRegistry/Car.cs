namespace Prototype.PrototypeRegistry;

public class Car : IClone<Car>
{
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    
    public Car Clone()
    {
        return new Car()
        {
            Model = Model,
            Year = Year,
            Color = Color,
        };
    }
    
    public override string ToString()
    {
        return $"Model: {Model}, Year: {Year}; Color: {Color}";
    }
}