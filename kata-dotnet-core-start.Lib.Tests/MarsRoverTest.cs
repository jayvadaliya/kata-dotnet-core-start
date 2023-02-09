namespace kata_dotnet_core_start.Lib.Tests;

public class MarsRoverTest
{
    [Fact]
    public void Verify_Given_Initial_Position_Direction()
    {
        // Act
        var marsRover = MarsRover.Init(1, 1, "S");

        // Assert
        var rover = marsRover.Rover;
        Assert.NotNull(rover);
        Assert.Equal(rover.Position.X,1);
        Assert.Equal(rover.Position.Y,1);
        Assert.NotNull(rover.Direction);
        Assert.Equal(rover.Direction.CurrentFacing, "S");
    }
}