namespace Builder.House.HouseBuilders;

public interface IHouseBuilder
{
    public IHouseBuilder Reset();
    public IHouseBuilder AddWindow();
    public IHouseBuilder AddRoof();
    public IHouseBuilder AddDoor();
    public IHouseBuilder AddWall(); 
    public IHouseBuilder AddBase();
    public House Build();

}