namespace Prototype.Car;

public class PrototypeCarRegistry
{
    private readonly IDictionary<string, Car> _cars = new Dictionary<string, Car>();
    
    public void AddItem(Car car)
    {
        if (car == null)
        {
            throw new ArgumentNullException("car");
        }

        if (!_cars.TryAdd(car.Brand, car))
        {
            throw new ArgumentException("Car already exists");
        }
    }

    public Car GetCarByBrand(string brand)
    {
        if (!_cars.TryGetValue(brand, out var outCar))
        {
            throw new ArgumentException("Brand not exists");
        }
        return outCar.Clone();
    }
}