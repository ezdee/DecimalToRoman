using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecimalToRomanLibrary;

namespace DecimalToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number to convert to roman: ");
            int dec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DecimalToRomanConvertor.ConvertToRoman(dec));
            Console.ReadLine();
        }
    }
}
