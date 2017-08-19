using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cheeseCalories = 500;
            int tomatoSauceCalories = 150;
            int salamiCalories = 600;
            int pepperCalories = 50;
            int totalCalories = 0;
            for (int i = 1; i <= n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":totalCalories += cheeseCalories; break;
                    case "tomato sauce":totalCalories += tomatoSauceCalories; break;
                    case "salami":totalCalories += salamiCalories; break;
                    case "pepper":totalCalories += pepperCalories; break;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
