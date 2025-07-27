namespace Prototype.PrototypeRegistry;

public class PrototypeCarRegistry
{
    private readonly IDictionary<string, Car> _cars = new Dictionary<string, Car>();
    
    public void AddItem(Car car)
    {
        if (car == null)
        {
            throw new ArgumentNullException("car");
        }

        if (_cars.ContainsKey(car.Model))
        {
            throw new ArgumentException("Car already exists");
        }
        
        _cars.Add(car.Model, car);
    }

    public Car GetCarByModel(string model)
    {
        if (!_cars.TryGetValue(model, out var outCar))
        {
            throw new ArgumentException("Model not exists");
        }
        return outCar.Clone();
    }
}