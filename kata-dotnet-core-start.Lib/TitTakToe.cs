namespace kata_dotnet_core_start.Lib;

public class TitTakToe
{
    public TitTakToe()
    {
        Board = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }

    public int[] Board { get; set; }
}