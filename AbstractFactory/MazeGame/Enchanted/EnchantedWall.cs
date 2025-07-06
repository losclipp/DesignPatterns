using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Enchanted;

public class EnchantedWall : Wall
{
    public EnchantedWall(int roomId, Direction direction)
        : base(roomId, direction)
    {
        
    }

    public override void Describe()
    {
        Console.WriteLine($"Enchanted wall {RoomId} with {Side}.");
    }
}