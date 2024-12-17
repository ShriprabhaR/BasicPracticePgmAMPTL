using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BasicPracticePgmAMPTL
{
    internal class PrimeNumberInArray
    {
        public static int GetPrimeNum(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 2;
                if (arr[i] %2 == 0)
                {
                    count++;
                }
                if (count == 2)
                {
                    return arr[i];
                }
            }
            return -1;
            
        }
    }
}
