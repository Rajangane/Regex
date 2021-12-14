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
        public String REGEX_FIRSTNAME = @"^[A-Z]{3}$"; //First name Contains capital 3 letters

        public bool ValidateFirstName(string name)
        {
            
            return Regex.IsMatch(name, REGEX_FIRSTNAME);
        }
    }
}
