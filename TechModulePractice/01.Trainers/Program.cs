using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double profit = 0.00;
            double technicalProfit = 0.00;
            double theoreticalProfit = 0.00;
            double practicalProfit = 0.00;
            string winningTeam;
            double winningTeamMoney = 0.00;
            for (int i = 0; i < n; i++)
            {
                int distance = int.Parse(Console.ReadLine()) * 1600;
                double cargoWeight = double.Parse(Console.ReadLine()) * 1000;
                string teamName = Console.ReadLine();
                profit = (cargoWeight * 1.5) - ((0.7 * distance) * 2.5);
                switch (teamName)
                {
                    case "Technical": technicalProfit += profit; break;
                    case "Theoretical": theoreticalProfit += profit; break;
                    case "Practical": practicalProfit += profit; break;

                }
            }
            if ((technicalProfit > theoreticalProfit) && (technicalProfit > practicalProfit))
            {
                winningTeam = "Technical";
                winningTeamMoney = technicalProfit;

            }
            else if ((theoreticalProfit > technicalProfit) && (theoreticalProfit > practicalProfit))
            {

                winningTeam = "Theoretical";
                winningTeamMoney = theoreticalProfit;

            }
            else
            {
                winningTeam = "Practical";
                winningTeamMoney = practicalProfit;
            }
            Console.WriteLine($"The {winningTeam} Trainers win with ${winningTeamMoney:f3}.");
        }
    }
}
