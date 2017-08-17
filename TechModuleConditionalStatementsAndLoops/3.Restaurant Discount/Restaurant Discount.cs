using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int packagePrice = 0;
            double discount = 0;
            int hallPrice = 0;
            int totalPrice = 0;

            switch (package)
            {
                case "Normal": discount = 0.95; packagePrice = 500; break;
                case "Gold": discount = 0.90; packagePrice = 750; break;
                case "Platinum": discount = 0.85; packagePrice = 1000; break;

            }
            if (count > 0 && count <= 50)
            {
                hallPrice = 2500;
                string hallName = "Small Hall";
                totalPrice = hallPrice + packagePrice;
                double finalPrice = totalPrice * discount;
                double pricePerPerson = finalPrice / count;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);

            }
            else if (count > 50 && count <= 100)
            {
                hallPrice = 5000;
                string hallName = "Terrace";
                totalPrice = hallPrice + packagePrice;
                double finalPrice = totalPrice * discount;
                double pricePerPerson = finalPrice / count;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else if (count > 100 && count <= 120)
            {
                hallPrice = 7500;
                string hallName = "Grand Hall";
                totalPrice = hallPrice + packagePrice;
                double finalPrice = totalPrice * discount;
                double pricePerPerson = finalPrice / count;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                
            }
            else if(count > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine("Error");
            }
            

            


        }
    }
}
