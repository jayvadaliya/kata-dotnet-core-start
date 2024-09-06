using System.Runtime.CompilerServices;

namespace kata_dotnet_core_start.Lib.Tests;

public class MarsMapTests
{
    [Fact]
    public void Initialize_MarsMap_Then_DefaultRowAndColumnInitialize()
    {
        // Act
        var result = new MarsMap();
        
        // Assert
        Assert.NotNull(result);
        Assert.Equal(5, result.Row);
        Assert.Equal(5, result.Column);
    }
    
    [Fact]
    public void When_MarsMap_Initialized_Then_VerifyDefineObstacles()
    {
        // Act 
        var result = new MarsMap();
        
        // Assert
        Assert.NotNull(result);
        Assert.Equal(3, result.Obstacles.Count);
        
        Assert.Equal(1, result.Obstacles.First().Key);
        Assert.Equal(3, result.Obstacles.First().Value);
        
        Assert.Equal(3, result.Obstacles.Skip(1).First().Key);
        Assert.Equal(4, result.Obstacles.Skip(1).First().Value);
        
        Assert.Equal(4, result.Obstacles.Last().Key);
        Assert.Equal(2, result.Obstacles.Last().Value);
    }
}