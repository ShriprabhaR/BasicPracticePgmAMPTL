using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPracticePgmAMPTL
{
    internal class Calculator
    {
        static void Main(String[] args)
        {
            int a;
            int b;
            Console.WriteLine("enter two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("sum of two numbers is: " + (a + b));
            Console.WriteLine("subtraction of two numbers is: " + (a - b));
            Console.WriteLine("multiplication of two numbers is: " + (a * b));
            Console.WriteLine("division of two numbers is: " + (a / b));
            Console.WriteLine("modulus of two numbers is: " + (a % b));
        }
    }
}
