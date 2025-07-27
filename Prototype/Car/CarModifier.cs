namespace Prototype.Car;

public static class CarModifier
{
    public static Car WithOwner(this Car car, Person owner)
    {
        if (owner == null)
        {
            throw new ArgumentNullException("owner");
        }
        var result = car.Clone();
        
        result.Owner = owner;
        return result;
    }

    public static Car WithColor(this Car car, string color)
    {
        if (string.IsNullOrWhiteSpace(color))
        {
            throw new ArgumentNullException("color");
        }
        
        var result = car.Clone();
        result.Color = color;
        return result;
    }
    
    public static Car WithYear(this Car car, int year)
    {
        if (year < 1900)
        {
            throw new ArgumentOutOfRangeException("year");
        }
        
        var result = car.Clone();

        result.Year = year;
        return result;
    }
    
    public static Car WithModel(this Car car, string model)
    {
        if (string.IsNullOrWhiteSpace(model))
        {
            throw new ArgumentNullException("model");
        }
        
        var result = car.Clone();

        result.Model = model;
        return result;
    }
}