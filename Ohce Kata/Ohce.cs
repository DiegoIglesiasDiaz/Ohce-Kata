using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohce_Kata
{
    public class Ohce
    {
        public Ohce()
        {
            actualHour = DateTime.Now.Hour;
        }

        public virtual int actualHour { get; set; }
        private string welcomeWord { get; } = "ohce ";
        private string stopWord { get; } = "Stop!";
        public virtual string name { get; set; }
        public virtual bool hasFinished { get; set; } = false;
        public virtual string AnalyzeText(string text)
        {
            if (text.Contains(welcomeWord, StringComparison.OrdinalIgnoreCase))
            {
                return GetWelcomePhrase(text);
            }
            if (text.Equals(stopWord))
            {
                hasFinished = true;
                return $"Adios {name}";
            }
            return PalindromeText(text);
        }
        public virtual string GetWelcomePhrase(string text)
        {


            name = text.Replace(welcomeWord, "");

            if (actualHour >= 6 && actualHour <= 12)
            {
                return $"¡Buenos Días {name}!";
            }
            if (actualHour >= 12 && actualHour <= 20)
            {
                return $"¡Buenas Tardes {name}!";
            }
            return $"¡Buenas Noches {name}!";
        }
        public virtual string PalindromeText(string text)
        {
            string textReverse = String.Concat(text.Reverse());
            return textReverse.Equals(text, StringComparison.OrdinalIgnoreCase) ? "¡Bonita palabra!" : textReverse;
        }
    }
}
