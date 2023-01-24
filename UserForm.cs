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
        public static void upperCasePassword()
        {
            Console.WriteLine("Enter Password Atleast one character should uppercase : ");
            string password = Console.ReadLine();

            Regex upperCase = new Regex(@"(?=.*[A-Za-z])[a-zA-Z]{8,35}");
            bool oneCharUpper = upperCase.IsMatch(password);
            if (oneCharUpper)
            {
                Console.WriteLine($"Valid uppercase Password : {password}");
            }
            else
            {
                Console.WriteLine($"Invalid uppercase Password : {password}");
            }
        }
    }
}
