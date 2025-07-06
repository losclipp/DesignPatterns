using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Bombed;

public class BombedMazeFactory : IMazeFactory
{
    public Door CreateDoor(int firstRoomId, Direction firstDirection, int secondRoomId, Direction secondDirection)
    {
        return new BombedDoor(firstRoomId, firstDirection, secondRoomId, secondDirection);
    }

    public Room CreateRoom(int roomId)
    {
        return new BombedRoom(roomId);
    }

    public Wall CreateWall(int roomId, Direction direction)
    {
        return new BombedWall(roomId, direction);
    }
}