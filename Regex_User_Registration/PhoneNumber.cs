using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_User_Registration
{
    public class PhoneNumber
    {
        public static void ValidatePhoneNumber()
        {
            string pattern = "^[0-9]{2}\\s[0-9]{10}$";
            string[] inputs = { "91 8407958538", "92 8475157485", "91 854751", "914512451212" };
            Console.WriteLine("Inputs are: ");
            Validation.PrintInputs(inputs);
            Console.WriteLine();
            Validation.ValidateInputs(inputs, pattern);
        }
    }
}
