using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            bool foundNumber = false;
            int match1 = 0;
            int match2 = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    if (i + j == magicNumber)
                    {
                        foundNumber = true;
                        match1 = i;
                        match2 = j;

                    }
                    count++;
                    
                }
            }
            if (foundNumber)
            {
                Console.WriteLine($"Number found! {match1} + {match2} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
            
           
        }
    }
}
