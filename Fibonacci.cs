using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPracticePgmAMPTL
{
    public class Fibonacci
    {
        static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            int first = 0, second =1, next ;
            Console.WriteLine("Fibonacci series of " + n + "are: ");
                for(int i=0; i<n; i++)
                {
                    Console.WriteLine(first + " ");
                    next = first + second;
                    first = second;
                    second = next;

                }
            Console.ReadLine();
            
        }
    }
}
