using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Bombed;

public class BombedWall : Wall
{
    public BombedWall(int roomId, Direction direction)
        : base(roomId, direction)
    {
        
    }

    public override void Describe()
    {
        Console.WriteLine($"Bombed wall {RoomId} with {Side}.");
    }
}