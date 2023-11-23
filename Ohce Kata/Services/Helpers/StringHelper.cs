using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohce_Kata.Services.Helpers
{
    public static class StringHelper
    {
        public static bool isInvalidName(string? name)
        {
            return string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit) || name.Any(char.IsSymbol);
        }
        public static string ReverseWord(string word)
        {
            var reverseWord = word.Reverse().ToArray();
            return new string(reverseWord);
        }
    }
}
