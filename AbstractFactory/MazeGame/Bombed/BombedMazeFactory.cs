using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Bombed;

public class BombedMazeFactory : IMazeFactory
{
    public Door CreateDoor(int firstRomId, int secondRoomId)
    {
        return new BombedDoor(firstRomId, secondRoomId);
    }

    public Room CreateRoom(int roomId)
    {
        return new BombedRoom(roomId);
    }

    public Wall CreateWall(int roomId)
    {
        return new BombedWall(roomId);
    }
}