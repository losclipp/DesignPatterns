namespace Prototype.Car;

public class Car: IClone<Car>
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    public string Color { get; set; }

    public Person? Owner { get; set; }

    public override string ToString()
    {
        var ownerString = Owner == null ? "No Owner" : Owner.ToString();
        return $"Brand: {Brand}, Model: {Model}, Year: {Year}; Owner: {ownerString}";
    }


    public Car Clone()
    {
        return new Car
        {
            Brand = Brand,
            Model = Model,
            Year = Year,
            Owner = Owner?.Clone()
        };
    }
}