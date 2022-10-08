using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProgramming
{
    public static class PowerOfTwo
    {
        public static void PrintTable()
        {
            Console.Write("Enter a number to print 2^N table: ");
            int exponentN = Convert.ToInt32(Console.ReadLine());

            if (exponentN >= 0 && exponentN < 31)
            {
                for (int i = 0; i < exponentN; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 0 and 31, excluding 31");
            }
        }
    }
}
