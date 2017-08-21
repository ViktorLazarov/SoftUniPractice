using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int turnCounter = 0;

            while (true)
            {
                
                turnCounter++;
                if (turnCounter % 2 == 1)
                {
                    // Pesho Attacking
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    // Gosho Attacking
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                
               
                if (turnCounter % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                
            }
            if (goshoHealth > peshoHealth)
            {
                Console.WriteLine($"Gosho won in {turnCounter}th round.");
            }
            else if (peshoHealth > goshoHealth)
            {
                Console.WriteLine($"Pesho won in {turnCounter}th round.");
            }
        }
    }
}
