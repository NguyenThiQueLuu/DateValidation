using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public class Helper
    {
        public static int DaysInMonth(int Year, int Month)
        {
            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
                return 31;
            else
            {
                if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                    return 30;
                else if (Month == 2)
                {
                    if (Year % 400 == 0)
                        return 29;
                    else if (Year % 100 == 0)
                        return 28;
                    else if (Year % 4 == 0)
                        return 29;
                    else return 28;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static bool IsValidDate(string strDay, string strMonth, string strYear)
        {
            int Day = CheckDays(strDay);
            int Month = CheckMonth(strMonth);
            int Year = CheckYear(strYear);
            if (Day > 0 && Month > 0 && Year > 0 && Day <= DaysInMonth(Year, Month))
                return true;
            return false;
        }

        public static int CheckDays(string strDay)
        {
            int Day = 0;
            try
            {
                Day = int.Parse(strDay);
            }
            catch
            {
                return -1;
            }
            if (Day < 1 || Day > 31)
            {
                return -2;
            }
            return Day;
        }

        public static int CheckMonth(string strMonth)
        {
            int Month = 0;
            try
            {
                Month = int.Parse(strMonth);
            }
            catch
            {
                return -1;
            }
            if (Month < 1 || Month > 12)
            {
                return -2;
            }
            return Month;
        }

        public static int CheckYear(string strYear)
        {
            int Year = 0;
            try
            {
                Year = int.Parse(strYear);
            }
            catch
            {
                return -1;
            }
            if (Year < 1000 || Year > 3000)
            {
                return -2;
            }
            return Year;
        }
    }
}
