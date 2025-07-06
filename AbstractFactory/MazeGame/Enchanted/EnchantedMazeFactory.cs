using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Enchanted;

public class EnchantedMazeFactory :IMazeFactory
{
    public Door CreateDoor(int firstRomId, int secondRoomId)
    {
        return new EnchantedDoor(firstRomId, secondRoomId);
    }

    public Room CreateRoom(int roomId)
    {
        return new EnchantedRoom(roomId);
    }

    public Wall CreateWall(int roomId)
    {
        return new EnchantedWall(roomId);
    }
}