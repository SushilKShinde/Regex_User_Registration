using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Regex_User_Registration
{
    public class FirstName
    {
        public static void ValidateFirstName()
        {
            string pattern = "^[A-Z][a-zA-Z]*$";
            string[] inputs = { "Sushil", "shWeta", "amiT", "Ojasss" };
            Console.WriteLine("Inputs are: ");
            PrintInputs(inputs);
            Console.WriteLine();
            ValidateInputs(inputs, pattern);
        }

        public static void PrintInputs(string[] inputs)
        {
            foreach (string input in inputs)
            {
                Console.Write($"{input} " );
            }
        }

        public static void ValidateInputs(string[] inputs, string pattern)
        {
            foreach(string s in inputs)
            {
                if(Regex.IsMatch(s,pattern))
                {
                    Console.WriteLine($"Valid input: {s}");
                }
                else
                {
                    Console.WriteLine($"Invalid Input: {s}");
                }
            }
        }
    }
}
