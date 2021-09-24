using System;

namespace SwapTwoNos
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking user inputs
            Console.Write("Please Enter The First Number = ");
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please Enter The Second Number = ");
            int SecondNumber = int.Parse(Console.ReadLine());
            //declare variable
            int temp = 0;
            //swapping 
            temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = temp;
            Console.WriteLine("First Number = " + FirstNumber);
            Console.WriteLine("Second Number = " + SecondNumber);
        }
    }
}
