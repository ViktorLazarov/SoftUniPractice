using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int locomotivePower = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int totalWeight = 0;
            int wagonCount = 0;
            int averageWeight = 0;
            while (input != "All ofboard!")
            {
                wagonCount++;
                int wagonWeight = int.Parse(input);
                totalWeight += wagonWeight;
                if (totalWeight > locomotivePower)
                {
                    averageWeight = totalWeight / wagonCount;

                }
                input = Console.ReadLine();
            }
        }
    }
}
