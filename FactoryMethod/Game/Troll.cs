using FactoryMethod.Game;

public class Troll : IEnemy
{
    public int Attack()
    {
        int damage = 2;
        Console.WriteLine($"Troll attacking and provide {damage}damage.");
        return damage;
    }
}