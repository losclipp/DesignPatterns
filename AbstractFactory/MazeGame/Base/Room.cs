namespace AbstractFactory.MazeGame.Base;

public class Room(int roomId) : IElementDescription
{
    public int RoomId { get; protected set; } = roomId;

    public virtual void Describe()
    {
        Console.WriteLine($"Usual Room {RoomId}");
    }
}