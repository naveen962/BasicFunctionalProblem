using System;

namespace QuotientRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking user inputs
            Console.Write("Enter the Divisor = ");
            int Divisor = int.Parse(Console.ReadLine());

            Console.Write("Enter the Dividend = ");
            int Dividend = int.Parse(Console.ReadLine());
            //computation
            int Quotient = Dividend / Divisor;
            Console.WriteLine("Quotient = " +Quotient);
            int Remainder = Dividend % Divisor;
            Console.WriteLine("Remainder = " +Remainder);
        }
    }
}
