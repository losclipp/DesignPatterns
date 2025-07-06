using AbstractFactory.MazeGame.Base;
using AbstractFactory.MazeGame.Bombed;
using AbstractFactory.MazeGame.Enchanted;

namespace AbstractFactory.MazeGame;

public class MazeBuilder
{
    private readonly IMazeFactory _mazeFactory;
    
    public MazeBuilder(MazeType mazeType)
    {
        switch (mazeType)
        {
            case MazeType.Bombed:
            {
                _mazeFactory = new BombedMazeFactory();
                break;
            }
            case MazeType.Enchanted:
            {
                _mazeFactory = new EnchantedMazeFactory();
                break;
            }
            default:
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    public Maze CreateGame()
    {
        var maze = new Maze();

        maze.Rooms.Add(_mazeFactory.CreateRoom(1));
        maze.Rooms.Add(_mazeFactory.CreateRoom(2));
        
        maze.Doors.Add(_mazeFactory.CreateDoor(1, Direction.Left,2, Direction.Right));
        
        maze.Walls.Add(_mazeFactory.CreateWall(1, Direction.Up));
        maze.Walls.Add(_mazeFactory.CreateWall(1, Direction.Down));
        maze.Walls.Add(_mazeFactory.CreateWall(1, Direction.Right));

        maze.Walls.Add(_mazeFactory.CreateWall(2, Direction.Up));
        maze.Walls.Add(_mazeFactory.CreateWall(2, Direction.Down));
        maze.Walls.Add(_mazeFactory.CreateWall(2, Direction.Left));
        
        return maze;
    }
}