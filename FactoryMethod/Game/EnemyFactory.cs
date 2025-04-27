namespace FactoryMethod.Game;

public static class EnemyFactory
{
    public static IEnemy CreateEnemy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.None:
            {
                return null;
            }
            case EnemyType.Goblin:
                return new Goblin();
            case EnemyType.Orc:
                return new Orc();
            case EnemyType.Troll:
                return new Troll();
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}