using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Regex = Regular expression >>>>>>>Pattern matching or input validation
            // ^ >>>>>> start of pattern
            //[pattern to match ]
            //{} >>>>> at least occurence 
            //$ >>>>>> end of pattern
            Console.WriteLine("Welcome To the validation of the User registration information by regex ");
            Console.WriteLine("Choose the correct option from the belo");
            Console.WriteLine("1.Validate first name\n2.Validate Last Name\n3.Validate Email id");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Validation.ValidateFirstName();
                    break;
                case 2:
                    LastName.ValidateLastName();
                    break;
                case 3:
                    EmailId.ValidateEmailId();
                    break;
                default:
                    Console.WriteLine("Please enter valid input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
