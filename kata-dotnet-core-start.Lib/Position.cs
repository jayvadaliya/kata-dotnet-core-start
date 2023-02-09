namespace kata_dotnet_core_start.Lib;

public class Position
{
    public Position(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }
}