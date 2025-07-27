namespace Prototype.Car;

public class Car: IClone<Car>
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car()
    {
        
    }
    
    public Car(Car car)
    {
        Brand = car.Brand;
        Model = car.Model;
        Year = car.Year;
    }

    public override string ToString()
    {
        return $"Brand: {Brand}, Model: {Model}, Year: {Year}";
    }


    public Car Clone()
    {
        return new Car(this);
    }
}