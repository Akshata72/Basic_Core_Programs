using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Alphabets
    {
        public void Alphabet()
        {

            Console.WriteLine("Enter a Alphabets:");

            int Latter = Convert.ToChar(Console.ReadLine().ToLower());
            int i = Latter;
            if (i >= 48 && i <= 57)
            {
                Console.WriteLine("You entered a number, Please enter an alpahbet.");
            }
            else
            {

                switch (Latter)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }

            }


        }

    }
}
