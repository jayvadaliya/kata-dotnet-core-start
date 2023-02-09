namespace kata_dotnet_core_start.Lib.Tests;

public class MarsRoverTest
{
    [Fact]
    public void Rover_Should_Have_Initial_Position_And_Direction()
    {
        //arrange
        var marsrover = MarsRover.Init();
        
        //act
        var rover = marsrover.Rover;
        
        //assert
        Assert.NotNull(rover);
        Assert.Equal(rover.Position.X,0);
        Assert.Equal(rover.Position.Y,0);
        Assert.NotNull(rover.Direction);
        Assert.Equal(rover.Direction.CurrentFacing,"N");

    }
}