namespace kata_dotnet_core_start.Lib;

public class MarsRover
{
    public MarsRover(int x, int y, string direction)
    {
        Rover = new Rover(x, y, direction);
    }

    public Rover Rover { get; set; }

    public static MarsRover Init(int x, int y, string direction)
    {
        return new MarsRover(x, y, direction);
    }
}