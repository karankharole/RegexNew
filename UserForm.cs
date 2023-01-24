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
                Console.WriteLine("Invalid last name");
            }
        }

        public static void userEmail()
        {
            string emailPattern = @"^[a][b][c]+([.][a-z A-Z 0-9]+)*@[bl]+.[co]{2,10}([.][a-z A-Z]{1,5})?$";
            Console.Write("Enter your email address : ");
            string email = Console.ReadLine();
            Regex emailValidate = new Regex(emailPattern);
            bool emailResult = emailValidate.IsMatch(email);

            if (emailResult)
            {
                Console.WriteLine($" Valid email  {email}");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }
        }

        public static void userMobile()
        {
            Console.WriteLine("Enter mobile number : ");
            long userNumber = Convert.ToInt64(Console.ReadLine());

            Regex mob = new Regex(@"[6-9]{1}[0-9]{9}");
            bool mobileNum = mob.IsMatch(userNumber.ToString());
            if (mobileNum)
            {
                Console.WriteLine("Valid Mobile number : " + userNumber);
            }
            else
            {
                Console.WriteLine("Invalid Mobile number : " + userNumber);

            }
        }
    }
}
