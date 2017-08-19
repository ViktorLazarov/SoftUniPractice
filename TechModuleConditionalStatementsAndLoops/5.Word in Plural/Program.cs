using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
            else if (word.EndsWith("o") ||
                    word.EndsWith("ch") ||
                    word.EndsWith("sh") ||
                    word.EndsWith("s") ||
                    word.EndsWith("x") ||
                    word.EndsWith("z"))
            {
                word += "es";

            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
