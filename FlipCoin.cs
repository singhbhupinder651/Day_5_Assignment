using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProgramming
{
    public static class FlipCoin
    {
        public static void CalculatePercentage()
        {
            int numOfHeads = 0, numOfTails = 0;
            Random random = new Random();

            Console.Write("Enter a number for number of flips: ");
            int numOfFlips = Convert.ToInt32(Console.ReadLine());

            if (numOfFlips > 0)
            {
                int numOfHeads = 0, numOfTails = 0;
                Random random = new Random();
                for (int i = 0; i < numOfFlips; i++)
                {
                    int flipResult = random.Next(0, 2);
                    if (flipResult > 0.5)
                    {
                        numOfHeads++;
                    }
                    else
                    {
                        numOfTails++;
                    }
                    Console.WriteLine("Heads: {0}\tTails: {1}", numOfHeads, numOfTails);
                }
                double percentHead = (double)numOfHeads / (double)numOfFlips * 100;
                double percentTail = (double)numOfTails / (double)numOfFlips * 100;
                Console.WriteLine("Percentage of heads: {0}%", percentHead);
                Console.WriteLine("Percentage of tails: {0}%", percentTail);
            }
            else
            {
                Console.WriteLine("Please enter a positive number");
            }
        }
    }
}
