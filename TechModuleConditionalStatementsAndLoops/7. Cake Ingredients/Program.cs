using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int counter = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    break;
                }
                Console.WriteLine($"Adding ingredient {input}.");
                counter++;
            }
            
        }
    }
}
