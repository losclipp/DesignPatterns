namespace AbstractFactory.MazeGame.Base;

public abstract class Door(int firstRoomId, Direction firstSide, int secondRoomId, Direction secondSide) : IElementDescription
{
    
    protected int firstRoomId = firstRoomId;
    protected int secondRoomId = secondRoomId;
    
    protected Direction firstSide = firstSide;
    protected Direction secondSide = secondSide;
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
        Console.WriteLine($"Usual Door {firstRoomId} with {firstSide} and {secondRoomId} with {secondSide}");
    }
}