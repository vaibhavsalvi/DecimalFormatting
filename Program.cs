using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalFormatting
{
    class Program
    {
        static decimal inputValue=0; 
        static void Main(string[] args)
        {
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(inputValue));
            inputValue = 33;
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(33));
            inputValue = 333.98M;
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(inputValue));
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(1.98453M));
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(123.4567M));
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(-567.2M));
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(-567.281789M));
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(-567.2817891234M));
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(-567.2817891234999M));
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(-5679999.2817891234999M));
            Console.WriteLine(Apply20PlacesAbsoluteNumericFormatSansDecimal(-12.123456789123456789M));
            Console.ReadLine();
            
        }

        static decimal Apply20PlacesAbsoluteNumericFormatSansDecimal(decimal inputValue)
        {            
            if (String.IsNullOrEmpty(inputValue.ToString()))
            {
                return Convert.ToDecimal(inputValue);
            }
            var inputValueString = Convert.ToString(Math.Abs(inputValue));
            int integerPart=0;
            if (inputValueString.IndexOf('.') > 0)
            {
                 integerPart = (inputValueString.Substring(0,  inputValueString.IndexOf('.'))).Length;
            }
            var roundTo = 20 - integerPart;
            return Math.Round(Convert.ToDecimal((inputValueString)),roundTo);
        }
    }
}

