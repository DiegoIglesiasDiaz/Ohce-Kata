using Ohce_Kata.Services.Helpers;
using Ohce_Kata.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohce_Kata.Services
{
    public class OhceKataService : Interfaces.IOhceKataService
    {
        public OhceKataService() { _dateTimeService = new DateService(); }
        public OhceKataService(IDateService dateService) { _dateTimeService = dateService; }
        private readonly IDateService _dateTimeService;

        public string GetGreets(string name)
        {
            var hour = _dateTimeService.GetHour();

            return hour switch
            {
                >= 6 and < 12 => $"¡Buenos dias {name}!",
                >= 12 and < 20 => $"¡Buenas tardes {name}!",
                _ => $"¡Buenas noches {name}!"

            };
            
        }

        public bool isPalindrome(string word)
        {
            return word.Equals(StringHelper.ReverseWord(word),StringComparison.OrdinalIgnoreCase);
        }


    }
}
