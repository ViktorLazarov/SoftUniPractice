using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = int.Parse(Console.ReadLine());
            double energy = int.Parse(Console.ReadLine());
            double sugar = int.Parse(Console.ReadLine());
            double multiplier = volume / 100;
            double totalEnergy = energy * multiplier;
            double totalSugar = sugar * multiplier;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");

        }
    }
}
