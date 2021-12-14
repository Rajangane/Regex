using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatching
{
    public class Patterns
    {
        public String REGEX_FIRSTNAME = @"^[A-Z]{3}$";//First name Contains capital 3 letters
        public String REGEX_LASTNAME = @"^[A-Z]{3}$"; //last name contains capital 3 letters
        public string REGEX_EMAIL = @"^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";//2-3 for com in co
        public string REGEX_PHONENO = @"^[6-9]{1}[0-9]{9}$"; // starting number between 6 to 9
        public bool ValidateFirstName(string name)
        {

            return Regex.IsMatch(name, REGEX_FIRSTNAME);
        }
        public bool ValidateLastName(string name)
        {

            return Regex.IsMatch(name, REGEX_FIRSTNAME);
        }
        public bool ValidateEmail(string email)
        {

            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidatePhoneNo(string phoneno)
        {

            return Regex.IsMatch(phoneno, REGEX_PHONENO);
        }
    }
}
