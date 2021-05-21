using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace hotel_management
{
    static class ExtensionMethods
    {
        public static bool CheckID(this string id)
        {
            return Regex.Match(id, @"^\d{12}$").Success;
        }

        public static bool CheckName(this string name)
        {
            return Regex.Match(name, @"^[A-Z][a-z]+(\s[A-Z][a-z]+)*$").Success;
        }

        public static bool CheckDate(this DateTime datetime)
        {
            return (datetime.CompareTo(DateTime.Now) <= 0);
        }

        public static bool EmailCheck(this String s)
        {
            return Regex.Match(s, @"^(\w+@\w+([.][a-zA-Z]+){1,4})$").Success;
        }

        public static bool PhoneCheck(this String s)
        {
            return Regex.Match(s, @"^([0][0-9]{2}[1-9]{7})$").Success;
        }
    }
}
