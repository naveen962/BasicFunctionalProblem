using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Number:");
            int num = int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine(num + "is EVEN");
            }
            else
            {
                Console.WriteLine(num + "is ODD");
            }
        }
    }
}
