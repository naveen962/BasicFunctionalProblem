
using System;

namespace VowelOrConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Alphabet : ");
            char Alpha = Console.ReadLine()[0];
            if ((Alpha >= 'A' && Alpha <= 'Z') || (Alpha >= 'a' && Alpha <= 'z'))
            {
                if (Alpha == 'A' || Alpha == 'E' || Alpha == 'I' || Alpha == 'O' || Alpha == 'U' || Alpha == 'a' || Alpha == 'e' || Alpha == 'i' || Alpha == 'o' || Alpha == 'u')
                {
                    Console.WriteLine("VOWEL");
                }
                else
                {
                    Console.WriteLine("CONSONANT");
                }
            }
            else
            {
                Console.WriteLine("NOT AN ALPHABET");

            }
        }
    }
}






