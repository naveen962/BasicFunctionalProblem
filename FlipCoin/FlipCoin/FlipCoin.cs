using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoin
{
    class FlipCoin
    {
        public static void TossCoin()
        {
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 1; i <= 20; i++)
            {
                Random ran = new Random();
                int result = ran.Next(0, 2);
                if (result == 0)
                {
                    Console.WriteLine("HEADS");
                    temp1 = temp1 + 1;



                }
                else
                {
                    Console.WriteLine("TAILS");
                    temp2 = temp2 + 1;


                }
            }
                int Headpercentage = ((100 * temp2) / 20);
                Console.WriteLine("Head Percentage="+Headpercentage);
                int Tailpercentage = ((100 * temp1) / 20);
                Console.WriteLine("Tailpercentage="+Tailpercentage);
            
        }

    }
}
