namespace kata_dotnet_core_start.Lib;

public static class FizzBuzz
{
    /// <summary>
    /// returns:
    /// Fizz if multiple of 3.
    /// Buzz if multiple of 5.
    /// FizzBuzz if multiple of 3 and 5.
    /// Input itself if none of above.
    /// </summary>
    public static string Check(int input)
    {
        if (IsMultipleOf3(input) && IsMultipleOf5(input))
        {
            return "FizzBuzz";
        }
        else if (IsMultipleOf3(input))
        {
            return "Fizz";
        }
        else if (IsMultipleOf5(input))
        {
            return "Buzz";
        }
        else
        {
            return input.ToString();
        }
    }

    private static bool IsMultipleOf3(int input)
    {
        return input % 3 == 0;
    }

    private static bool IsMultipleOf5(int input)
    {
        return input % 5 == 0;
    }
}
