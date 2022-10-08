using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProgramming
{
    public static class SwapTwoNumbers
    {
        public static void Swap()
        {
            Console.Write("Enter value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After swapping value of a: " + a);
            Console.WriteLine("After swapping value of b: " + b);
        }
    }
}
