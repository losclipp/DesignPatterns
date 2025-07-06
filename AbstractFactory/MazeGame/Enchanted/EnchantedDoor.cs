using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame.Enchanted;

public class EnchantedDoor : Door
{
    public EnchantedDoor(int firstRomId, Direction firstDirection, int secondRoomId, Direction secondDirection) 
        :base(firstRomId, firstDirection, secondRoomId, secondDirection)
    {
        
    }

    public override void Describe()
    {
        Console.WriteLine($"Enchanted door for {firstRoomId} with {firstSide} and {secondRoomId} with {secondSide}.");
    }
}