namespace kata_dotnet_core_start.Lib.Tests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(3,"Fizz")]
    [InlineData(9,"Fizz")]
    public void WhenMultipleOf3ReturnFizz(int input, string output)
    {
        //Act
        var result = FizzBuzz.Check(input);
        //Assert
        Assert.Equal(output, result);
    }
    
    [Theory]
    [InlineData(5,"Buzz")]
    [InlineData(20,"Buzz")]
    public void WhenMultipleOf5ReturnBuzz(int input, string output)
    {
        //Act
        var result = FizzBuzz.Check(input);
        //Assert
        Assert.Equal(output, result);
    }
    
    
    [Theory]
    [InlineData(15,"FizzBuzz")]
    [InlineData(60,"FizzBuzz")]
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