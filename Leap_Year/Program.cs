using System;
using System.IO;

namespace Leap_Year
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year");
            string input = Console.ReadLine();
            int res = Convert.ToInt32(input);

            bool LeapYear = IsLeapYear(res);
            if(LeapYear)
            {
                Console.WriteLine("yay, it is a leap year");
            }else
            {
                Console.WriteLine("oh no, it is not a leap year");
            }
        }

        public static bool IsLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        return true;
                    }else
                    {
                        return false;
                    }
                }else
                {
                    return true;
                }
            }else
            {
                return false;
            }
        }
    }
}

