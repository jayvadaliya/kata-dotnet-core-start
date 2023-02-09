namespace kata_dotnet_core_start.Lib.Tests;

public class MarsRoverTest
{
    [Fact]
    public void Verify_Given_Initial_Position_Direction()
    {
        // Act
        var marsRover = MarsRover.Init(1, 1, 'S');

        // Assert
        var rover = marsRover.Rover;
        Assert.NotNull(rover);
        Assert.Equal(rover.Position.X,1);
        Assert.Equal(rover.Position.Y,1);
        Assert.NotNull(rover.Direction);
        Assert.Equal(rover.Direction.CurrentFacing, 'S');
    }
    
    [Fact]
    public void Map_Initialize()
    {
        // Arrange
        var marsRover = MarsRover.Init(1, 1, 'S');
        
        //Act
        
        var map = marsRover.GenerateMap(); 

        // Assert
        
        Assert.NotNull(map);
        //Assert.Equal(map.Count(),9);
    }
    
    // [Fact]
    // public void Given_Command_To_Rover_Then_Position_And_Direction_Should_Be_Changed()
    // {
    //     // Arrange
    //     var marsRover = MarsRover.Init(1, 1, 'S');
    //     
    //     //Act
    //     
    //     var rover = marsRover.MoveRover(new char[]{'F','B'}); 
    //
    //     // Assert
    //     
    //     Assert.NotNull(rover);
    //     Assert.Equal(rover.Position.X,2);
    //     Assert.Equal(rover.Position.Y,1);
    //     Assert.NotNull(rover.Direction);
    //     Assert.Equal(rover.Direction.CurrentFacing, 'E');
    // }
    
    
}