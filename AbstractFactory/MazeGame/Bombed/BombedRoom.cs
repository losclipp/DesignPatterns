using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Bombed;

public class BombedRoom : Room
{
    public BombedRoom(int roomId) 
        : base(roomId)
    {
        
    }

    public override void Describe()
    {
        Console.WriteLine($"Bombed room {RoomId}.");
    }
}