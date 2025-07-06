using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Bombed;

public class BombedWall : Wall
{
    public BombedWall(int roomId)
        : base(roomId)
    {
        
    }

    public override void Describe()
    {
        Console.WriteLine($"Bombed room {RoomId}.");
    }
}