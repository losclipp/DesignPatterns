// See https://aka.ms/new-console-template for more information

using AbstractFactory.MazeGame;
using AbstractFactory.MazeGame.Base;


Console.WriteLine("Hello, World!");

var mazeFactory = new MazeFactory(MazeType.Bombed);
var maze = mazeFactory.CreateGame();


Console.WriteLine("Rooms");
foreach (var room in maze.Rooms)
{
    room.Describe();
}

Console.WriteLine("Doors");
foreach (var room in maze.Doors)
{
    room.Describe();
}

Console.WriteLine("Walls");
foreach (var room in maze.Walls)
{
    room.Describe();
}

Console.ReadLine();