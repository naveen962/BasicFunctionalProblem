using System;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the no of terms : ");
            int n = int.Parse(Console.ReadLine());
            float s = 0.0f;
           
            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", n, s);
        }
    }
}