using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProgramming
{
    public static class QuotientRemainder
    {
        public static void Compute()
        {
            Console.Write("Enter a dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            double quotient = dividend / divisor;
            double remainder = dividend % divisor;

            Console.WriteLine("Quotient is: " + quotient);
            Console.WriteLine("Remainder is: " + remainder);
        }
    }
}
