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
        if (input % 3 == 0 && IsMultipleOf5(input))
        {
            return "FizzBuzz";
        }
        else if (input % 3 == 0)
        {
            return "Fizz";
        }
        else if (input % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return input.ToString();
        }
    }

    private static bool IsMultipleOf5(int input)
    {
        return input % 5 == 0;
    }
}
