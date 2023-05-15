using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_User_Registration
{
   public class LastName
    {
        public static void ValidateLastName()
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            string[] inputs = { "Shinde", "meshraM", "mE"};
            Console.WriteLine("Inputs are: ");
            Validation.PrintInputs(inputs);
            Console.WriteLine();
            Validation.ValidateInputs(inputs, pattern);
        }
    }
}
