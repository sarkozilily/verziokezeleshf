using System;

namespace verziokezeleshf
{
    class Program
    {
        static void Main(string[] args)
        {

            
            double atlag;
            int i, x, osszeadas = 0;

            Console.Write("Adjon meg 10 számot! \n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("A(z) {0}. szám :", i);

                x = Convert.ToInt32(Console.ReadLine());
                osszeadas += x;
            }
            atlag = osszeadas / 10.0;
            Console.Write("Az átlaguk : "+ atlag);
        }

    }
   }

        
    
