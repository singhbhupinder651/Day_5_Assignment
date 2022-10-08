using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProgramming
{
    public static class LeapYear
    {
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter a four digit number to determine if its a leap year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year > 999 && year < 10000)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
                {
                    Console.WriteLine(year + " is a leap year");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Please enter a four digit number");
            }

        }
    }
}
