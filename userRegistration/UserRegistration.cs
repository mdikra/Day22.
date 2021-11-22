using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace userRegistration
{
    class UserRegistration :IValidator
    {
        /// <summary>
        /// interface method to match inputted string with inputted regular expression
        /// </summary>
        /// <param name="regexExpression"> regular expression </param>
        /// <param name="stringToMatch"> string to match with regular expression </param>
        /// <returns></returns>
        public string CheckMatch(string regexExpression, string stringToMatch)
        {
            Match match = Regex.Match(stringToMatch, regexExpression, RegexOptions.None);
            if (match.Success)
                return "valid";
            else
                return "invalid";
        }

        /// <summary>
        /// interface method to validate name
        /// </summary>
        /// <param name="name"> the name string to be checked for validation </param>
        /// <returns></returns>
        public string ValidateName(string name)
        {
            string expression = @"^[A-Z]{1}[a-z]{2,}$";
            return this.CheckMatch(expression, name);

        }

        /// <summary>
        /// interface method to validate email
        /// </summary>
        /// <param name="email"> the email string to be checked for validation </param>
        /// <returns></returns>
        public string ValidateEmail(string email)
        {
            string expression = @"^abc((\.[A-Z]+[a-z][0-9])|(\.[A-Z][a-z]+[0-9])|(\.[A-Z][a-z][0-9]+)?)?@bl\.co(\.[a-z]{2,})?$";
            return this.CheckMatch(expression, email);
        }

        /// <summary>
        /// interface method to validate number
        /// </summary>
        /// <param name="number"> the number to be checked for validation </param>
        /// <returns></returns>
        public string ValidateNumber(string number)
        {
            string expression = @"^([0-9]{2}[ ]{1}[0-9]{10})$";
            return this.CheckMatch(expression, number);
        }

        /// <summary>
        /// interface method to validate password
        /// </summary>
        /// <param name="password"> the password to be checked for validation </param>
        /// <returns></returns>
        public string ValidatePassword(string password)
        {
            string expression = @"^(?=.[A-Z])(?=.[0-9])(?=[^@#$%^&+=][@#$%^&+=][^@#$%^&+=]$)(.{8,})$";
            return this.CheckMatch(expression, password);
        }

        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();

            // first name
            string firstName = UserInput.InputFirstName();
            // validating first name
            Console.WriteLine($"First name {userRegistration.ValidateName(firstName)}");

            // last name
            string lastName = UserInput.InputLastName();
            // validating last name
            Console.WriteLine($"Last name {userRegistration.ValidateName(lastName)}");

            // taking email form user
            string email = UserInput.InputEmail();
            // validating email
            Console.WriteLine($"Email {userRegistration.ValidateEmail(email)}");

            // taking number from user
            string number = UserInput.InputNumber();
            // validating number
            Console.WriteLine($"Number {userRegistration.ValidateNumber(number)}");

            // taking password from user
            string password = UserInput.InputPassword();
            // validating password
            Console.WriteLine($"Password {userRegistration.ValidatePassword(password)}");



        }
    }
}