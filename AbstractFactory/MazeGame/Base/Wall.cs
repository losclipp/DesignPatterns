namespace AbstractFactory.MazeGame.Base;

public abstract class Wall (int roomId, Direction direction) : IElementDescription
{
    public Direction Side { get; protected set; } = direction;
    public int RoomId { get; protected set; } = roomId;
    public virtual void Describe()
    {
        Console.WriteLine($"Usual Wall {RoomId} with {Side}");
    }
}