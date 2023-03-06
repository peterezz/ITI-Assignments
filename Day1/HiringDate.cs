using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day1
{
    internal class HiringDate
    {
        public int day { get; set; } = 0;
        public int month { get; set; } = 0;
        public int year { get; set; } = 0;
        public HiringDate(string date)
        {
            Regex validateDateRegex = new Regex("^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$");
            if (validateDateRegex.IsMatch(date))
            {   // prints True
               int day = int.Parse(date.Split('/')[0]);
                if(day <=31)
                    this.day = day;
               int month = int.Parse(date.Split('/')[1]);
                if(month <=12)
                    this.month= month;
                int year = int.Parse(date.Split('/')[2]);
                if(year >=2000 && year<=DateTime.Now.Year)
                    this.year= year;
            }
        }
        public override string ToString()
        {
            if (day == 0 || month == 0 || year == 0)
                return "";
            return $"Hiring Date: {day} - {month} - {year}";
        }
        public  string GetDateTime()
        {
            if (day == 0 || month == 0 || year == 0)
                return "";
            return $"{month}-{day}-{year}";
        }
    }
}
