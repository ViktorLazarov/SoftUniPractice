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
                case "Normal": discount = 1.05; packagePrice = 500; break;
                case "Gold": discount = 1.10; packagePrice = 750; break;
                case "Platinum": discount = 1.15; packagePrice = 1000; break;

            }
            if (count <= 50)
            {
                hallPrice = 2500;
                string hallName = "Small Hall";
            }
            else if (count > 50 && count <= 100)
            {
                hallPrice = 5000;
                string hallName = "Terrace";
            }
            else if (count > 100)
            {
                hallPrice = 7500;
                string hallName = "Great Hall";

            }
            totalPrice = hallPrice + packagePrice;
            double finalPrice = totalPrice / discount;
            double pricePerPerson = finalPrice / count;

            Console.WriteLine("We can offer you the {0}", hallName);
            Console.WriteLine("The price per person is {0}", pricePerPerson);


        }
    }
}
