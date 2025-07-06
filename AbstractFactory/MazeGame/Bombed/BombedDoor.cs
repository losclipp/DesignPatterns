using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Bombed;

public class BombedDoor : Door
{
    public BombedDoor(int firstRomId, Direction firstDirection, int secondRoomId, Direction secondDirection) 
        :base(firstRomId, firstDirection, secondRoomId, secondDirection)
    {
        
    }

    public override void Describe()
    {
        Console.WriteLine($"Bombed door for {firstRoomId} with {firstSide} and {secondRoomId} with {secondSide}.");
    }
}