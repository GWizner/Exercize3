// See https://aka.ms/new-console-template for more information
double userIn = 0;

Console.WriteLine("Pick a number:");
string userInput = Console.ReadLine();
double.TryParse(userInput, out userIn);
Console.WriteLine();
Console.WriteLine(userIn + .5);
Console.ReadLine();