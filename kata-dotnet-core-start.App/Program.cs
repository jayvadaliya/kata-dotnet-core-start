// See https://aka.ms/new-console-template for more information

using kata_dotnet_core_start.Lib;

var startWith = 1;
var endWith = 100;

for (int i = startWith; i <= endWith; i++)
{
    Console.WriteLine(FizzBuzz.Check(i));
}