using System;

namespace Regex_User_Registration
{
    public class EmailId
    {
        public static void ValidateEmailId()
        { 
            string pattern = "^[a-zA-Z]+[-+_.]?[a-z0-9]*@[a-zA-Z0-9]+.[a-zA-Z]+.([a-z]{2})*$";
            string[] inputs = { "sks@gmail.com", "Ska@gmail.com", "sks.gmail.com","sks123@gmail.com.inlll" };
            Console.WriteLine("Inputs are: ");
            Validation.PrintInputs(inputs);
            Console.WriteLine();
            Validation.ValidateInputs(inputs, pattern);
        }
    }
}
