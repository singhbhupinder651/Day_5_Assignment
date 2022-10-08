namespace CoreAndFunctionalProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs!");
            Console.WriteLine("Program #1: Flip Coin");
            Console.WriteLine("Program #2: Leap Year");
            Console.WriteLine("Program #3: Power of 2");
            Console.WriteLine("Program #4: Harmonic Number");
            Console.WriteLine("Program #5: Factors");
            Console.WriteLine("Program #6: Compute Quotient and Remainder");
            Console.WriteLine("Program #7: Swap Two Numbers");
            Console.WriteLine("Program #8: Number is Even or Odd");
            Console.WriteLine("Program #9: Alphabet is Vowel or Consonant");

            Console.Write("Please select a program to run from options above: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoin.CalculatePercentage();
                    break;
                case 2:
                    LeapYear.CheckLeapYear();
                    break;
                case 3:
                    PowerOfTwo.PrintTable();
                    break;
                case 4:
                    HarmonicNumber.PrintSeries();
                    break;
                case 5:
                    Factors.PrimeFactors();
                    break;
                case 6:
                    QuotientRemainder.Compute();
                    break;
                case 7:
                    SwapTwoNumbers.Swap();
                    break;
                case 8:
                    EvenOrOdd.NumberEvenOrOdd();
                    break;
                case 9:
                    VowelOrConsonant.AlphabetCheck();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }
        }
    }
}