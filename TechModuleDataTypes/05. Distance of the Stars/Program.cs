using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYearToKm = 9450000000000;
            decimal earthToProxima = lightYearToKm * 4.22m;
            decimal centerOfGalaxy = lightYearToKm * 26000;
            decimal milkyWayDiameter = lightYearToKm * 100000;
            decimal earthToEdgeOfUniverse = lightYearToKm * 46500000000m;

            Console.WriteLine($"{earthToProxima:e2}");
            Console.WriteLine($"{ centerOfGalaxy:e2}");
            Console.WriteLine($"{milkyWayDiameter:e2}");
            Console.WriteLine($"{earthToEdgeOfUniverse:e2}");
        
        }
    }
}
