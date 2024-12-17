using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BasicPracticePgmAMPTL
{
    internal class CheckPresence
    {
        public static void CheckIfPresent(String str)
        {
             char[] ch = str.ToCharArray();
            int a = 0, e = 0, p = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a')
                {
                    a++;
                }
                else if (ch[i] == 'e')
                {
                    e++;
                }
                else if (ch[i] == 'p')
                {
                    p++;
                }
            }

            if(a!=0 && e!=0 && p != 0)
            {
                Console.WriteLine("All present");
            }
            else if(a !=0 || e!=0 || p != 0)
            {
                Console.WriteLine("One or more present");
            }
            else
            {
                Console.WriteLine("None Present");
            }

            
        }
    }
}
