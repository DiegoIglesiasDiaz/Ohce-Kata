using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohce_Kata.Services.Interfaces
{
    public interface IOhceKataService
    {
        void GetGreets(string name);
        void Palindrome(string text);
        bool isPalindrome(string word);
        string ReverseWord(string word);

    }
}
