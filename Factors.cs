using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProgramming
{
    public static class Factors
    {
        public static void PrimeFactors()
        {
            Console.Write("Enter a number to find its prime factors: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Prime factors of " + num + " are: ");

            //firstly we reduce num by factors of 2 so only odd prime factors are left
            while (num % 2 == 0)
            {
                Console.Write("2 ");
                num = num / 2;
            }

            //now we check for odd prime factors in the range (2 <= primeFactors <= √num)
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num = num / i;
                }
            }

            //if num is greater than 2 and is prime, then it will fail
            //conditions of both loops above. to handle a prime number greater than 2
            //we apply the if loop below since its only prime factor is the number itself
            if (num > 2)
            {
                Console.Write(num);
            }
        }
    }
}
