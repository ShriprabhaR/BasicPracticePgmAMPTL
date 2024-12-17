using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPracticePgmAMPTL
{
    internal class PlingPlangPlong
    {
        public static void PrintString(int n)
        {
            if (n % 3 == 0 && n % 5 == 0 && n % 7 == 0)
            {
                Console.WriteLine("Pling Plang Plong ");
            }
            else if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("Pling Plang");
            }
            else if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("Pling Plong");
            }
            else if (n % 5 == 0 && n % 7 == 0)
            {
                Console.WriteLine("Plang Plong");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("Pling");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("Plang");
            }
            else
            {
                Console.WriteLine("Plong");
            }

        }
    }
}
