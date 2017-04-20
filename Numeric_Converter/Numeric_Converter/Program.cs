using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "DEC")
            {
                if (output == "HEX")
                {
                    int number = int.Parse(inputNumber);


                }
                else if (output == "BIN")
                {

                }
            }
            else if (input == "HEX")
            {
                if (output == "DEC")
                {

                }
                else if (output == "BIN")
                {

                }
            }
            else if (input == "BIN")
            {
                if (output == "HEX")
                {

                }
                else if (output == "DEC")
                {

                }
               
            }
        }

        
    }
}
