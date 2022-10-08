using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProgramming
{
    public static class HarmonicNumber
    {
        public static void PrintSeries()
        {
            Console.Write("Enter a number to get harmonic series and its Nth harmonic value: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                int count = 1;
                while (count < num)
                {
                    Console.Write("1/" + count + " + ");
                    count++;
                }
                Console.Write("1/" + num);

                double sum = 0;
                for (double i = 1; i <= num; i++)
                {
                    sum += 1 / i;
                }
                Console.WriteLine("\nValue of Nth Harmonic: " + sum);
            }
            else
            {
                Console.WriteLine("Enter a number greater than zero");
            }
        }
    }
}
