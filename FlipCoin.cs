using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FunProblem
{
    internal class FlipCoin
    {
        public void Flip_Percentage()
        {
            int HEAD = 0;
            int TAIL = 0;

            Console.WriteLine("Enter the number of time to flip the coin");
            int numberOfFlips = Convert.ToInt32(Console.ReadLine());

            while (numberOfFlips <= 0)
            {
                Console.WriteLine("Enter the valid number greater than Zero");
                numberOfFlips = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numberOfFlips; i++)
            {
                Random random = new Random();
                int value = random.Next(0, 2);

                if (value < 0.5)
                {
                    HEAD++;
                }
                else
                {
                    TAIL++;
                }
            }

            float headPercent = (float)HEAD * 100 / numberOfFlips;
            float tailPercent = (float)TAIL * 100 / numberOfFlips;

            Console.WriteLine("Head percentage is:" + headPercent);
            Console.WriteLine("Tail percentage is:" + tailPercent);

        }
    }
}
