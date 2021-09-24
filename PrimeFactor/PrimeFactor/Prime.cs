using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeFactor
{
    class Prime
    {
        public static void PrimeFact()
        {
            Console.WriteLine("Please enter the Number!!!");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Prime Factors are:");
            int i = 2;
            
            while (num>1)
                {
                    if (num % i == 0)
                    {
                   
                    Console.WriteLine(i);
                    num = num / i;
                    }
                    else
                    {
                        i++;
                    }
                }
        }
    }
}
