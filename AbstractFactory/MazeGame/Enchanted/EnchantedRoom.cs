using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Enchanted;

public class EnchantedRoom : Room
{
    public EnchantedRoom(int roomId)
        : base(roomId)
    {
        
    }

    public override void Describe()
    {
        Console.WriteLine($"Enchanted room {RoomId}.");
    }
}