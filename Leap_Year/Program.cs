using System;
using System.IO;

namespace Leap_Year
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static bool IsLeapYear(int year){
            if(year % 4 == 0){
                if(year % 100 == 0){
                    if(year % 400 == 0){
                        return true;
                    }else{
                        return false;
                    }
                }else{
                    return true;
                }
            }else{
                return false;
            }
        }
    }
}

