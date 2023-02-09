namespace kata_dotnet_core_start.Lib;

public class Rover
{
    public Rover(int x, int y, string direction)
    {
        Position = new Position(x, y);
        Direction = new Direction(direction);
    }
    
    public Position Position { get; set; }
    public Direction Direction { get; set; }

    
}