namespace kata_dotnet_core_start.Lib;

public class Direction
{
    public Direction(string direction)
    {
        this.CurrentFacing = direction;
    }

    public string CurrentFacing { get; set; }
}