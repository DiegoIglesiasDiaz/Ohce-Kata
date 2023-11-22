using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohce_Kata.Services
{
    public class OhceKataService : Interfaces.IOhceKataService
    {
        public OhceKataService() { }

        public void GetGreets(string name)
        {
            var hour = DateTime.Now.Hour;

            var greetsPhrase = hour switch
            {
                > 6 and < 12 => $"¡Buenos dias {name}!",
                > 12 and < 20 => $"!Buenas tardes {name}!",
                _ => $"!Buenas noches {name}!"

            };
            Console.WriteLine(greetsPhrase);
        }

        public void Palindrome(string text)
        {
            if (isPalindrome(text))
            {
                Console.WriteLine(text);
                Console.WriteLine("!Bonita Palabra¡");
            }
            else
            {
                Console.WriteLine(ReverseWord(text));
            }
        }
        public bool isPalindrome(string word)
        {
            return word.Equals(ReverseWord(word));
        }

        public string ReverseWord(string word)
        {
            var reverseWord = word.Reverse().ToArray();
            return new string(reverseWord);
        }
    }
}
