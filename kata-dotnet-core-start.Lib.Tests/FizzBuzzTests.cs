namespace kata_dotnet_core_start.Lib.Tests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(3,Constants.MultipleOf3)]
    [InlineData(9,Constants.MultipleOf3)]
    public void WhenMultipleOf3ReturnFizz(int input, string output)
    {
        //Act
        var result = FizzBuzz.Check(input);
        //Assert
        Assert.Equal(output, result);
    }
    
    [Theory]
    [InlineData(5, Constants.MultipleOf5)]
    [InlineData(20, Constants.MultipleOf5)]
    public void WhenMultipleOf5ReturnBuzz(int input, string output)
    {
        //Act
        var result = FizzBuzz.Check(input);
        //Assert
        Assert.Equal(output, result);
    }
    
    
    [Theory]
    [InlineData(15, Constants.MultipleOf3And5)]
    [InlineData(60, Constants.MultipleOf3And5)]
    public void WhenMultipleOf3And5ReturnFizzBuzz(int input, string output)
    {
        //Act
        var result = FizzBuzz.Check(input);
        //Assert
        Assert.Equal(output, result);
    }
    
    [Theory]
    [InlineData(1,"1")]
    [InlineData(98,"98")]
    public void WhenNotMultipleOf3And5ReturnInput(int input, string output)
    {
        //Act
        var result = FizzBuzz.Check(input);
        //Assert
        Assert.Equal(output, result);
    }
}