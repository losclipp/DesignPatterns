using AbstractFactory.MazeGame.Base;

namespace AbstractFactory.MazeGame;

public class Maze
{
    public readonly IList<Room> Rooms = new List<Room>();
    public readonly IList<Wall> Walls = new List<Wall>();
    public readonly IList<Door> Doors = new List<Door>();
}