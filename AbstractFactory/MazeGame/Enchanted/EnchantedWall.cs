using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Enchanted;

public class EnchantedWall : Wall
{
    public EnchantedWall(int roomId)
        : base(roomId)
    {
        
    }

    public override void Describe()
    {
        Console.WriteLine($"Enchanted room {RoomId}.");
    }
}