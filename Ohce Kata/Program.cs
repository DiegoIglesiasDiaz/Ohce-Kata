
using Ohce_Kata;

var ohce = new Ohce();
bool StopApplication = false;


while (!StopApplication)
{
    string? inputText = Console.ReadLine();
    if (inputText != null)
    {
        Console.WriteLine(ohce.AnalyzeText(inputText));
        StopApplication = ohce.hasFinished;
       
    }
       
}
