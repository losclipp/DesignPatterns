namespace AbstractFactory.MazeGame.Base;

public abstract class Wall (int roomId) : IElementDescription
{
    public int RoomId { get; protected set; } = roomId;
    public virtual void Describe()
    {
        Console.WriteLine($"Usual Wall {RoomId}");
    }
}