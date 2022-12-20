using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class NumberInPassword
    {
        public static string Regex_Numeric = "((?=.*[A-Z])(?=.*[0-9]).{8,})";
        public bool ValidateNumeric(string Numeric)
        {
            return Regex.IsMatch(Numeric, Regex_Numeric);
        }
    }
}
