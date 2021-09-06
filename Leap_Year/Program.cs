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
            int res;

            bool convert_to_int = Int32.TryParse(input, out res);

            bool LeapYear = IsLeapYear(res);
            if(convert_to_int)
            {
               if(res < 1582)
                {
                    Console.WriteLine("Input is invalid. Please input year from 1582 and fourth");
                }else if(LeapYear)
                {
                    Console.WriteLine("yay, it is a leap year");
                }else
                {
                    Console.WriteLine("oh no, it is not a leap year");
                } 
            }else{
                Console.WriteLine("Letters and decimal numbers are not allowed. Please input year in integer format.");
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

