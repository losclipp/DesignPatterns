using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Bombed;

public class BombedDoor : Door
{
    public BombedDoor(int firstRomId, int secondRoomId) 
        :base(firstRomId, secondRoomId)
    {
        
    }

    public override void Describe()
    {
        Console.WriteLine($"Bombed door for {firstRoomId} and {secondRoomId}");
    }
}