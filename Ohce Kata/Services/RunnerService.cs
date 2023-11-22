using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohce_Kata.Services
{
    public class RunnerService : Interfaces.IRunnerService
    {
        public RunnerService(OhceKataService _ohceKataService)
        {
            ohceKataService = _ohceKataService;
        }

        private string? name { get; set; }
        const string STOPWORD = "Stop!";
        private readonly OhceKataService ohceKataService;
        public void Run()
        {
            SetupName();

            do
            {
                var inputText = Console.ReadLine();
                if (inputText == STOPWORD)
                    break;
                if (string.IsNullOrWhiteSpace(inputText))
                    PrintErrorMessage("You must type a word");
                else
                    ohceKataService.Palindrome(inputText);

            } while (true);



        }
        public void SetupName()
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

            ohceKataService.GetGreets(name);
        }
        public void PrintErrorMessage(string phrase)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + phrase);
            Console.ResetColor();
        }
        public string GetNameFromConsole()
        {
            Console.WriteLine("What`s your name?");
            var consoleOutput = Console.ReadLine();
            if (isInvalidName(consoleOutput))
                throw new ArgumentException("Introduce a valid name");
            return consoleOutput;
        }

        public bool isInvalidName(string? name)
        {
            return string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit) || name.Any(char.IsSymbol);
        }
    }
}
