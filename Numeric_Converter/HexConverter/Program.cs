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
            //Write a program that converts a number(decimal or binary) into hexadecimal format
            string numberInput = Console.ReadLine();
            string inputSystem = Console.ReadLine();
            string result = string.Empty;
            if (inputSystem == "DEC")
            {
                string remainder;

                int number = int.Parse(numberInput);
                while (number != 0)
                {
                    remainder = (number % 16).ToString();
                    switch (remainder)
                    {
                        case "10": remainder = "A"; break;
                        case "11": remainder = "B"; break;
                        case "12": remainder = "C"; break;
                        case "13": remainder = "D"; break;
                        case "14": remainder = "E"; break;
                        case "15": remainder = "F"; break;

                    }
                    number /= 16;
                    result += remainder;
                }
                char[] resultChar = result.ToCharArray();
                for (int i = resultChar.Length - 1; i >= 0; i--)
                {
                    Console.Write(resultChar[i]);
                }
                Console.WriteLine();
                
            }
            else if (inputSystem == "BIN")
            {
                char[] binInput = numberInput.ToCharArray();
                double resultNumber = 0;
                int pow = binInput.Length - 1;
                for (int i = 0; i <= binInput.Length - 1; i++)
                {
                    resultNumber += int.Parse(binInput[i].ToString()) * (Math.Pow(2, pow));
                    pow--;

                }
            
                string remainder;
                
                while (resultNumber != 0)
                {
                    remainder = (resultNumber % 16).ToString();
                    switch (remainder)
                    {
                        case "10": remainder = "A"; break;
                        case "11": remainder = "B"; break;
                        case "12": remainder = "C"; break;
                        case "13": remainder = "D"; break;
                        case "14": remainder = "E"; break;
                        case "15": remainder = "F"; break;

                    }
                    resultNumber = Math.Floor(resultNumber / 16);
                    result += remainder;


                }
                char[] resultChar = result.ToCharArray();
                for (int i = resultChar.Length-1; i >= 0; i--)
                {
                    Console.Write(resultChar[i]);
                }
                Console.WriteLine();
                

            }


        }
    }
}
