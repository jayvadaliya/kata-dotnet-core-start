namespace kata_dotnet_core_start.Lib.Tests;

public class TicTakToeTests
{
    [Fact]
    public void When_start_game_then_board_shouldBeInitialized()
    {
        // Arrange
        
        // Act
        var result = new TitTakToe();

        // Assert
        Assert.NotNull(result);
        Assert.NotNull(result.Board);
        Assert.Equal(9, result.Board.Length);
    }

    [Fact]
    public void When_start_game_then_two_players_X_And_O_ShowBeAvailable()
    {
        // Arrange
        
        // Act
        var result = new TitTakToe();

        // Assert
        Assert.NotNull(result);
        Assert.NotNull(result.Board);
        Assert.Equal(9, result.Board.Length);
        Assert.Equal(2, result.Players.Length);
        Assert.Contains("X", result.Players);
        Assert.Contains("O", result.Players);
    }
}