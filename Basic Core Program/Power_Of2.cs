using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Power
    {
        public void Power_Of2()
        {
            Console.WriteLine("Enter number of Powers:");
            int num = int.Parse(Console.ReadLine());
            if (0 <= num << 31)
            {

                double Power = (double)Math.Pow(2, num);
                Console.WriteLine(Power);


            }
            else
            {
                Console.WriteLine("OverFlow....");
            }


        }
        
    }
}
