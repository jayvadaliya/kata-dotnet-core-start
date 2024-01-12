using System.Runtime.CompilerServices;

namespace kata_dotnet_core_start.Lib;

public class TitTakToe
{
    public TitTakToe()
    {
        Board = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        Players = new string[] { "X", "O" };
    }

    public string[] Board { get; set; }
    
    public string[] Players { get; set; }

    public void MovePosition(string playerName, int position)
    {
        Board[position] = playerName;
    }
}