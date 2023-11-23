using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohce_Kata.Services.Interfaces
{
    public interface IDateService
    {
        DateTime GetDateTime();
        int GetHour();
        void SetDateTime(DateTime date);
    }
}
