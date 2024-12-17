using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPracticePgmAMPTL
{
    internal class Print1To100
    {
        int n = 1;
        public static void Print(int n)
        {
            if (n <= 100)
            {
                Console.Write("{0} ", n++);
                Print(n);
            }
        }

    }
}
