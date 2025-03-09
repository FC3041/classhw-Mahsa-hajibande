using System;

namespace _8
{
    class Program
    {
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static int DaysInMonth(int month, int year)
        {
            if (month > 12 || month < 1)
            {
                Console.WriteLine("The month must be between 1 and 12.");
                return -1;
            }
            else
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    return 31;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    return 30;
                }
                else if (month == 2)
                {
                    if (IsLeapYear(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
                else
                {
                    return -1;
                }
            }
        }

        static int DaysBeforeDate(int year, int month, int day)
        {
            int days = 0;
            for (int mon = 1; mon < month; mon++)
            {
                days += DaysInMonth(mon, year);
            }
            days += (day - 1);

            return days;
        }

        static void Main(string[] args)
        {
            int year = 2014;
            int month = 12;
            int day = 31;
            Console.WriteLine(DaysBeforeDate(year, month, day));
        }
    }
}