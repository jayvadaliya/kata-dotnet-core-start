namespace kata_dotnet_core_start.Lib;

public class Direction
{
    public Direction(char direction)
    {
        this.CurrentFacing = direction;
    }

    public char CurrentFacing { get; set; }
}