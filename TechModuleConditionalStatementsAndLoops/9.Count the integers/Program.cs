using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Count_the_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int counter = 0;
            int number;
            while (true)
            {
                bool result = Int32.TryParse(input, out number);

                if (result)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine(counter);
                    break;
                }
                input = Console.ReadLine();
            }
        
        }
    }
}
