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
            Dictionary<int, string> roman = new Dictionary<int, string>
                {
                    {1,"I"},
                    {4,"IV"},
                    {5,"V"},
                    {9,"IX"},
                    {10,"X"},
                    {40,"XL"},
                    {50,"L"}
                };

            return roman[decimalNum];
        }
    }
}
