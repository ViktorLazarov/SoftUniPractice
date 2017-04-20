using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInput = Console.ReadLine();
            string inputSystem = Console.ReadLine();
            string result = string.Empty;
            if (inputSystem == "DEC")
            {
                string remainder ;
                int number = int.Parse(numberInput);
                while (number != 0)
                {
                    remainder = (number % 16).ToString();
                    switch (remainder)
                    {
                        case "10":remainder = "A"; break;
                        case "11": remainder = "B"; break;
                        case "12": remainder = "C"; break;
                        case "13": remainder = "D"; break;
                        case "14": remainder = "E"; break;
                        case "15": remainder = "F"; break;
                        
                    }
                    number /= 16;
                    result += remainder;
                }
            }
            else if (inputSystem == "BIN")
            {



            }
            Console.WriteLine(result);

        }
    }
}
