using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexNew
{
    internal class UserForm
    {
        public static void userForm()
        {
            string first = @"^[A-Z]{1}[a-z A-Z]{2,10}";
            Console.WriteLine("Enter first name : ");
            string fName = Console.ReadLine();
            Regex name = new Regex(first);
            bool n = name.IsMatch(fName);
            if (n)
            {
                Console.WriteLine($" Valid First Name: {fName}");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }

        }
    }
}
