﻿namespace kata_dotnet_core_start.Lib;

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
            return Constants.MultipleOf3And5;
        }
        else if (IsMultipleOf3(input))
        {
            return Constants.MultipleOf3;
        }
        else if (IsMultipleOf5(input))
        {
            return Constants.MultipleOf5;
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
