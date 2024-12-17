using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPracticePgmAMPTL
{
    internal class AvgOfFloats
    {
        public static double GetAvg(double[] arr)
        {
            double sum = 0, avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                sum = sum +arr[i];

            }
            avg = sum / arr.Length;
            return avg;
            

        }
    }
}
