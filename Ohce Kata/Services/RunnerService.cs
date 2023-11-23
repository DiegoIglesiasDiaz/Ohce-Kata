using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohce_Kata.Services.Helpers;
namespace Ohce_Kata.Services
{
    public class RunnerService : Interfaces.IRunnerService
    {
        public RunnerService()
        {
            ohceKataService = new OhceKataService();
        }

        private string? name { get; set; }
        const string STOP_WORD = "Stop!";
        private readonly OhceKataService ohceKataService;
        public void Run()
        {
            bool isValidName = false;
            do
            {
                try
                {
                    name = GetNameFromConsole();
                    isValidName = true;
                }
                catch (ArgumentException ex)
                {
                    PrintErrorMessage(ex.Message);
                }
            } while (!isValidName);

            Console.WriteLine(ohceKataService.GetGreets(name));

            do
            {
                var inputText = Console.ReadLine();
                if (inputText == STOP_WORD)
                    break;
                if (string.IsNullOrWhiteSpace(inputText))
                    PrintErrorMessage("You must type a word");
                else
                {
                    AnalyzeWord(inputText);
                }

            } while (true);



        }
        public void AnalyzeWord(string text)
        {
            Console.WriteLine(StringHelper.ReverseWord(text));

            if (ohceKataService.isPalindrome(text))
                Console.WriteLine("!Bonita Palabra¡");

        }
        public string GetNameFromConsole()
        {
            Console.WriteLine("What`s your name?");
            var consoleOutput = Console.ReadLine();
            if (StringHelper.isInvalidName(consoleOutput))
                throw new ArgumentException("Introduce a valid name");
            return consoleOutput;
        }
        private void PrintErrorMessage(string phrase)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + phrase);
            Console.ResetColor();
        }
        public string? GetName()
        {
            return name;
        }
 
    }
}
