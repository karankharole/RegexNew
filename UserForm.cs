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
            string emailPattern = @"^[A-Za-z]{3,}([.][A-Za-z]{3,})?[@][A-Za-z]{2,}[.][A-Za-z]{2,}([.][A-Za-z]{2})?$";

            Console.Write("Enter first name : ");
            string fName = Console.ReadLine();
            Console.Write("Enter last name : ");
            string lName = Console.ReadLine();
            Console.Write("Enter your email address : ");
            string email = Console.ReadLine();

            Regex name = new Regex(first);

            Regex emailValidate = new Regex(emailPattern);

            bool frst = name.IsMatch(fName);
            bool lst = name.IsMatch(lName);
            bool emailResult = emailValidate.IsMatch(email);




            if (frst)
            {
                Console.WriteLine($" Valid First Name {fName}");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }
            if (lst)
            {
                Console.WriteLine($" Valid Last Name {lName}");
            }
            else
            {
                Console.WriteLine("Invalide last name");
            }
            if (emailResult)
            {
                Console.WriteLine($" Valid email  {email}");
            }
            else
            {
                Console.WriteLine("Invalid email");
            }


        }
    }
}
