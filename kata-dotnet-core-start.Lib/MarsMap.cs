namespace kata_dotnet_core_start.Lib;

public class MarsMap
{
    public MarsMap()
    {
        Row = 5;
        Column = 5;
        Obstacles = new Dictionary<int, int>()
        {
             {1, 3},
             {3, 4},
             {4, 2}
        };
    }

    public int Row { get; set; }
    
    public int Column { get; set; }
    
    public Dictionary<int,int> Obstacles { get; set; }
}