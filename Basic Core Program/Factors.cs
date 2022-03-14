using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Factors
    {

        public void Factor()
        {

            int Count = 0;
            Console.WriteLine("Enter a Number:");
            int Num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine("Factors :" + i);
                    Count++;
                }



            }
            Console.WriteLine("Number Of Factors:" + Count);
        }

    }
}
