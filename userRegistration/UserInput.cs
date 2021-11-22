using System;
using System.Collections.Generic;
using System.Text;

namespace userRegistration
{
    class UserInput
    {
        /// <summary>
        /// method to take first name from user
        /// </summary>
        /// <returns></returns>
        public static string InputFirstName()
        {
            Console.Write("Enter First name : ");
            return Console.ReadLine();
        }

        /// <summary>
        /// method to take last name from user
        /// </summary>
        /// <returns></returns>
        public static string InputLastName()
        {
            Console.Write("Enter Last name : ");
            return Console.ReadLine();
        }

        /// <summary>
        /// method to take email from user
        /// </summary>
        /// <returns></returns>
        public static string InputEmail()
        {
            Console.Write("Enter email : ");
            return Console.ReadLine();
        }

        /// <summary>
        /// method to take number from user
        /// </summary>
        /// <returns></returns>
        public static string InputNumber()
        {
            Console.Write("Enter number with country code : ");
            return Console.ReadLine();
        }

        /// <summary>
        /// method to take password from user
        /// </summary>
        /// <returns></returns>
        public static string InputPassword()
        {
            Console.Write("Enter password : ");
            return Console.ReadLine();
        }
    }
}