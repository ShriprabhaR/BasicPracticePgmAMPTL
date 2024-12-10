using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPracticePgmAMPTL
{
    internal class PowerOfN
    {
        static void Main(string[] args)
        {
            int n, p;
            Console.WriteLine("enter 2 numbers");
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());

            int prod = 1;
            for(int i = 0; i < p; i++) 
            {
                prod = prod * n;
            }
            Console.WriteLine(prod);

        }
    }
}
