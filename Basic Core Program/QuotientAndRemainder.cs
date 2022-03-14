using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class QuotientAndRemainder
    {
        public void QuotientRemainder()
        {

            Console.WriteLine("Enter a Dividend:");
            int Dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Divisor:");
            int Divisor = int.Parse(Console.ReadLine());
            int Quotient = Dividend / Divisor;
            int Remainder = Dividend % Divisor;
            Console.WriteLine("Quotient:" + Quotient);
            Console.WriteLine("Remainder:" + Remainder);

        }

    }
}
