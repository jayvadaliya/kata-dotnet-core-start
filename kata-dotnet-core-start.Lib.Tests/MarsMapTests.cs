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
}