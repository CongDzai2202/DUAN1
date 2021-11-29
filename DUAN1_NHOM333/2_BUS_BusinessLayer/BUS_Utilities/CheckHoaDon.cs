using _2_BUS_BusinessLayer.BUS_IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_Utilities
{
    public class CheckHoaDon
    {
        public bool checkString(string input)
        {
            if (input.All(char.IsDigit))
            {
                return true;
            }

            return false;
        }

        public bool checkNumber(string input)
        {
            if (Regex.IsMatch(input, @"[^\d+$]") == true)
            {
                return true;
            }

            return false;
        }

        public bool checkNull(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return true;
            }

            return false;
        }
    }
}
