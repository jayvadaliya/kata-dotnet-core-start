namespace kata_dotnet_core_start.Lib;

public class Rover
{
    public Rover()
    {
        Position = new Position();
        Direction = new Direction();
    }
    
    public Position Position { get; set; }
    public Direction Direction { get; set; }

    
}