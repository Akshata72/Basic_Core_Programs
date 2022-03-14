using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LargestNumber
    {

        public void Largestnumber()
        {

            Console.Write("Input the 1st number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The  " +num1+ "  Number is the greatest among three. ");
                }
                else
                {
                    Console.Write("The " +num2+ " Number is the greatest among three. ");
                }
            }
            else if (num2 > num3)
                Console.Write("The "+num2+"  Number is the greatest among three ");
            else
                Console.Write("The "+num3+" Number is the greatest among three ");




        }
    }
}
