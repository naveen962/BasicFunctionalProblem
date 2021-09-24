using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 3 Numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1>n2 && n1>n3)
            {
                Console.WriteLine(n1+" is the largest");

            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine(n2+" is the largest");

            }
            else
            {
                Console.WriteLine(n3+" is the largest");

            }
        }
       
    }
}
