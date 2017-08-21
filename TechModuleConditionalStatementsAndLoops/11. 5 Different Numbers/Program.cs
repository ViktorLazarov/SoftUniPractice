using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            if (max-min < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int n1 = min; n1 <= max-4; n1++)
                {
                    for (int n2 = n1+1; n2 <= max-3; n2++)
                    {
                        for (int n3 = n2+1; n3 <= max-2; n3++)
                        {
                            for (int n4 = n3+1; n4 <= max-1; n4++)
                            {
                                for (int n5 = n4+1; n5 <= max; n5++)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    
                                }
                            }
                        }
                    }
                }
            }

            
            
        }
    }
}
