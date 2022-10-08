using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProgramming
{
    public static class EvenOrOdd
    {
        public static void NumberEvenOrOdd()
        {
            Console.Write("Enter a number to check if it is even or odd: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num %2 == 0)
            {
                Console.WriteLine(num + " is an even number");
            }
            else
            {
                Console.WriteLine(num + " is an odd number");
            }
        }
    }
}
