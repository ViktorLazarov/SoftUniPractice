using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0.00;
            double doublePrice = 0.00;
            double suitePrice = 0.00;
            double studioFinalPrice = 0.00;
            double doubleFinalPrice = 0.00;
            double suiteFinalPrice = 0.00;
            switch (month)
            {
                case "May":
                case "October": studioPrice = 50; doublePrice = 65; suitePrice = 75; break;
                case "June":
                case "September": studioPrice = 60; doublePrice = 72; suitePrice = 82; break;
                case "July":
                case "August":
                case "December": studioPrice = 68; doublePrice = 77; suitePrice = 89; break;
            }

            if ((month == "May" || month == "October") && nights > 7)
            {
                studioPrice *= 0.95;
            }
            else if ((month == "June" || month == "September") && nights > 14)
            {
                doublePrice *= 0.90;
            }
            else if ((month == "July" || month == "August" || month == "December") && nights > 14)
            {
                suitePrice *= 0.85;
            }
            studioFinalPrice = nights * studioPrice;
            doubleFinalPrice = nights * doublePrice;
            suiteFinalPrice = nights * suitePrice;
            if ((month == "September" || month == "October") && nights > 7)
            {
                studioFinalPrice -= studioPrice;
            }

            Console.WriteLine($"Studio: {studioFinalPrice:f2} lv.");
            Console.WriteLine($"Double: {doubleFinalPrice:f2} lv.");
            Console.WriteLine($"Suite: {suiteFinalPrice:f2} lv.");


        }
    }
}
