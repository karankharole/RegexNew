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
            Console.Write("Enter first name : ");
            string fName = Console.ReadLine();
            Console.Write("Enter last name : ");
            string lName = Console.ReadLine();

            Regex name = new Regex(first);

            bool frst = name.IsMatch(fName);
            bool lst = name.IsMatch(lName);

            if (frst)
            {
                Console.WriteLine($" Valide First Name {fName}");
            }
            else
            {
                Console.WriteLine("Invalide first name");
            }
            if (lst)
            {
                Console.WriteLine($" Valide Last Name {lName}");
            }
            else
            {
                Console.WriteLine("Invalide last name");
            }

        }
    }
}
