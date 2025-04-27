namespace FactoryMethod.Game;

public class Orc : IEnemy
{
    public int Attack()
    {
        int damage = 3;
        Console.WriteLine($"Orc attacking and provide {damage} damage.");
        return damage;
    }
}