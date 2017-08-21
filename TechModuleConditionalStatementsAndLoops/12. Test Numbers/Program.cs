using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    
                    if (sum < maxSum)
                    {
                        sum += 3 * (i * j);
                        count++;
                    }
                    
                }
            }
            if (sum >= maxSum)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
                
            }
            else
            {
                 Console.WriteLine($"{count} combinations");
                 Console.WriteLine($"Sum: {sum}");
                    
            }

        }
    }
}
