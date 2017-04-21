using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program that converts a number in HEX or DEC to binary 
            Console.Write("Enter a number to convert: ");
            string numberInput = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Specify the type of the entered number(exaple:HEX or DEC): ");
            string inputSystem = Console.ReadLine();
            string result = string.Empty;

            if (inputSystem == "DEC")
            {
                string remainder;

                int number = int.Parse(numberInput);
                while (number > 0)
                {
                    remainder = (number % 2).ToString();

                    number /= 2;
                    result += remainder;
                }
                char[] resultChar = result.ToCharArray();
                Array.Reverse(resultChar);
                Console.WriteLine(new string(resultChar));


            }
            else if (inputSystem == "HEX")
            {
                char[] hexInput = numberInput.ToCharArray();
                int[] intValuedHex = new int[hexInput.Length];
                double resultNumber = 0;
                int pow = hexInput.Length - 1;
                for (int i = 0; i < intValuedHex.Length; i++)
                {
                    switch (hexInput[i])
                    {
                        case 'A': intValuedHex[i] = 10; break;
                        case 'B': intValuedHex[i] = 11; break;
                        case 'C': intValuedHex[i] = 12; break;
                        case 'D': intValuedHex[i] = 13; break;
                        case 'E': intValuedHex[i] = 14; break;
                        case 'F': intValuedHex[i] = 15; break;
                        default:
                            intValuedHex[i] = int.Parse(hexInput[i].ToString());
                            break;
                    }
                    resultNumber += intValuedHex[i] * (Math.Pow(16, pow));
                    pow--;

                }
                int resultInt = Convert.ToInt32(resultNumber);
                int remainder = 0;
                while (resultInt > 0)
                {
                    remainder = resultInt % 2;

                    resultInt /= 2;
                    result += remainder;
                }
                char[] resultChar = result.ToCharArray();
                Array.Reverse(resultChar);
                Console.WriteLine(new string(resultChar));


            }
        }
    }
}
