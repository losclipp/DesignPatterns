using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Enchanted;

public class EnchantedMazeFactory :IMazeFactory
{
    public Door CreateDoor(int firstRoomId, Direction firstDirection, int secondRoomId, Direction secondDirection)
    {
        return new EnchantedDoor(firstRoomId, firstDirection, secondRoomId, secondDirection);
    }

    public Room CreateRoom(int roomId)
    {
        return new EnchantedRoom(roomId);
    }

    public Wall CreateWall(int roomId, Direction direction)
    {
        return new EnchantedWall(roomId, direction);
    }
}