using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class SwapTwoNumber
    {

        public void SwapTwoNumbers()
        {

            Console.WriteLine("Enter a Variable a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Variable b:");   
            int b = int.Parse(Console.ReadLine());
            //a = a * b;
            //b = a / b;
            //a = a / b;
            // Or
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("b=" +b);
            Console.WriteLine("a=" +a);
        }
    }
}
