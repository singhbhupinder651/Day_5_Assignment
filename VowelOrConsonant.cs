using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProgramming
{
    public static class VowelOrConsonant
    {
        public static void AlphabetCheck()
        {
            Console.Write("Enter an alphabet to check if it is Vowel or Consonant: ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u' || alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
            {
                Console.WriteLine(alphabet + " is a vowel");
            }
            else
            {
                Console.WriteLine(alphabet + " is a consonant");
            }
        }
    }
}
