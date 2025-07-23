namespace Builder.House.HouseBuilders;

public class ConcreteHouseBuilder : IHouseBuilder
{
    private House _house = new House();
    public IHouseBuilder Reset()
    {
        _house = new House();
        return this;
    }

    public IHouseBuilder AddWindow()
    {
        _house.Windows.Add("Concrete windows");;
        return this;
    }

    public IHouseBuilder AddRoof()
    {
        if (!string.IsNullOrEmpty(_house.Roof))
        {
            throw new Exception("Roof already present");
        }

        _house.Roof = "Concrete roof";
        return this;
    }

    public IHouseBuilder AddDoor()
    {
        _house.Doors.Add("Concrete door");;
        return this;
    }

    public IHouseBuilder AddWall()
    {
        _house.Walls.Add("Concrete wall");
        return this;
    }

    public IHouseBuilder AddBase()
    {
        if (!string.IsNullOrEmpty(_house.Base))
        {
            throw new Exception("Base already present");
        }
        _house.Base = "Concrete base";
        return this;
    }


    public House Build()
    {
        if (string.IsNullOrEmpty(_house.Base))
        {
            throw new ArgumentNullException("Base"); 
        }
        
        if (string.IsNullOrEmpty(_house.Roof))
        {
            throw new ArgumentNullException("Roof");
        }

        if (_house.Walls == null || _house.Walls.Count < 4)
        {
            throw new ArgumentException("House should has at least four walls.");
        }

        if (_house.Doors == null || _house.Doors.Count < 1)
        {
            throw new ArgumentException("House should have at least one door.");
        }
        return _house;
    }
}