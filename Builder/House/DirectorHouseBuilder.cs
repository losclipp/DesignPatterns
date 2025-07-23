using Builder.House.HouseBuilders;

namespace Builder.House;

public class DirectorHouseBuilder
{
    private IHouseBuilder _builder;
    
    public DirectorHouseBuilder(IHouseBuilder builder)
    {
        _builder = builder;
    }

    public House Build()
    {
        return _builder
            .AddBase()
            .AddRoof()
            .AddWall()
            .AddWall()
            .AddWall()
            .AddWall()
            .AddDoor()
            .AddWindow()
            .AddWindow()
            .AddWindow()
            .Build();
    }
}