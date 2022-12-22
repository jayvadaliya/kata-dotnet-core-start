namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Theory] 
    [InlineData(1,"1")]
    [InlineData(3,"Fizz")]
    [InlineData(5,"Buzz")]
    [InlineData(15,"FizzBuzz")]
    public void CheckFizzBuzz(int input, string output)
    {
        //Arrange
        
        //Act
        var result = FizzBuzz.GetFizzBuzz(input);
        //Assert
        Assert.Equal(output, result);
    }
}