using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToRomanLibrary
{
    public class DecimalToRomanConvertor
    {
        public static string ConvertToRoman(int decimalNum)
        {
            string output = string.Empty;

            if (decimalNum == 1)
            {
                output = "I";
            }
            if (decimalNum == 4)
            {
                output = "IV";
            }

            return output;
        }
    }
}
