using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    public class PerfectNumber
    {
        public static void PerfectNum()
        {
            int n, i, sum;
            int mn, mx;

            Console.WriteLine("Find the numbers within a given number of range");
            Console.WriteLine("Input the starting range or number");

            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range of numbers");

            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("To perfect number within the given range : ");
        
            for (n=mn;n<=mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = (sum + i);
                    i++;
                    
                }
                if (sum == n)
                    Console.WriteLine("{0}", n);
            }
            
        }
        
    }
}

