using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Enchanted;

public class EnchantedDoor : Door
{
    public EnchantedDoor(int firstRomId, int secondRoomId) 
        : base(firstRomId, secondRoomId)
    {
        
    }

    public override void Describe()
    {
        Console.WriteLine($"Enchanted door for {firstRoomId} and {secondRoomId}");
    }
}