using System;
using System.Collections.Generic;
using System.Text;

namespace userRegistration
{
    interface Interface1
    {
        /// <summary>
        /// method to match inputted string with inputted regular expression
        /// </summary>
        /// <param name="regexExpression"> regular expression </param>
        /// <param name="stringToCheck"> string to match with regular expression </param>
        /// <returns></returns>
        string CheckMatch(string regexExpression, string stringToCheck);

        /// <summary>
        /// method to validate name
        /// </summary>
        /// <param name="name"> the name string to be checked for validation </param>
        /// <returns></returns>
        string ValidateName(string name);

        /// <summary>
        /// method to validate email
        /// </summary>
        /// <param name="email"> the email string to be checked for validation </param>
        /// <returns></returns>
        string ValidateEmail(string email);

        /// <summary>
        /// method to validate number
        /// </summary>
        /// <param name="number"> the number to be checked for validation </param>
        /// <returns></returns>
        string ValidateNumber(string number);

        /// <summary>
        /// method to validate password
        /// </summary>
        /// <param name="password"> the password to be checked for validation </param>
        /// <returns></returns>
        string ValidatePassword(string password);
    }
}
