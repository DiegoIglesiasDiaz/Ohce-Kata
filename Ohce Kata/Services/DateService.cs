using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohce_Kata.Services
{
    public class DateService : Interfaces.IDateService
    {
       private DateTime _date;
        public DateService(DateTime date) { _date = date; }
        public DateService() { _date = DateTime.Now; }

        public DateTime GetDateTime()
        {
            return _date;
        }
        public int GetHour()
        {
            return _date.Hour;
        }
        public void SetDateTime(DateTime date)
        {
             _date = date;
        }
    }
}
