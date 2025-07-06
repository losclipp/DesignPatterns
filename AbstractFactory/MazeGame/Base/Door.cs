namespace AbstractFactory.MazeGame.Base;

public abstract class Door(int firstRoomId, int secondRoomId) : IElementDescription
{
    protected int firstRoomId = firstRoomId;
    protected int secondRoomId = secondRoomId;
    public bool IsOpen { get; protected set; } = false;

    public void OpenDoor()
    {
        IsOpen = !IsOpen;
    }

    Tuple<int, int> GetRoomsIds()
    {
        return new Tuple<int, int>(firstRoomId, secondRoomId);
    }
    
    public virtual void Describe()
    {
        Console.WriteLine($"Usual Door {firstRoomId} {secondRoomId}");
    }
}