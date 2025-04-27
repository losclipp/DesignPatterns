namespace FactoryMethod.Game;

public class Goblin : IEnemy
{
    public int Attack()
    {
        int damage = 1;
        Console.WriteLine($"Goblin attacking and provide {damage} damage.");
        return damage;
    }
}