using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Harmonics
    {

        public void Harmonic()
        {

            Console.WriteLine("Input the Number of terms:");
            int Num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= Num; i++)
            {

                Console.Write("1/{0} + ", i);

            }


        }
        
            
               
             
                
     
            
    }
}

