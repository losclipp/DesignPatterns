namespace AbstractFactory.MazeGame.Base;

public interface IMazeFactory
{
    Door CreateDoor(int firstRoomId, Direction firstDirection,  int secondRoomId, Direction secondDirection );
    Room CreateRoom(int roomId);
    Wall CreateWall(int roomId, Direction direction);
}