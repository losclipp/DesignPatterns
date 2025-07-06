namespace AbstractFactory.MazeGame.Base;

public interface IMazeFactory
{
    Door CreateDoor(int firstRomId, int secondRoomId);
    Room CreateRoom(int roomId);
    Wall CreateWall(int roomId);
}