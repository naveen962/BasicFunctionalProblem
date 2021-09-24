using System;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Number!!!");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The power of 2 table are:");
            int i = 1;
            while(i<n)
            {

              Console.WriteLine ( Math.Pow(2,i));
                i++;
            }
        }
    }
}
