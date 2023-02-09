namespace kata_dotnet_core_start.Lib;

public class MarsRover
{
    public MarsRover()
    {
        Rover = new Rover();
    }

    public Rover Rover { get; set; }

    public static MarsRover Init()
    {
        return new MarsRover();
    }
}