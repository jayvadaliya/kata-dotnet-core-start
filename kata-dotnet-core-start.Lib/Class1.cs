namespace kata_dotnet_core_start.Lib;
public static class FizzBuzz
{
    public static string GetFizzBuzz(int input)
    {
        //TODO : refactor
        if (input % 3 == 0 && input % 5 == 0)
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

}
