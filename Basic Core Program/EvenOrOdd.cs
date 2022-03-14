using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class EvenOrOdd
    {
        public void EvenorOdd()
        {


            Console.WriteLine("Enter a Number to Check :");
            int Number = int.Parse(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine("Number {0} is a Even number", Number);
            }
            else
            {
                Console.WriteLine("Number {0} is a Odd number", Number);
            }

        }
    }
}
