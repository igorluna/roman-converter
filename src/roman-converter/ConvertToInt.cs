using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace roman_converter
{
    public enum RomanNumbers
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000,
    }

    public static class ConvertToInt
    {
        public static int ToInt(this string romanNumber)
        {
            Regex romanRegex = new Regex("^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
            if (!romanRegex.IsMatch(romanNumber))
                throw new InvalidCastException("Invalid roman number.");

            int convertedValue = 0;

            string romanNumberReversed = string.Join("", romanNumber.Select(x => x).Reverse());

            var lastChecked = 1;
            foreach (char rNumber in romanNumberReversed)
            {
                // convert to int
                RomanNumbers currentNumber = Enum.Parse<RomanNumbers>(rNumber.ToString());

                if ((int)currentNumber >= lastChecked)
                {
                    convertedValue += (int)currentNumber;
                }
                else
                {
                    convertedValue -= (int)currentNumber;
                }
                lastChecked = (int)currentNumber;


            }
            return convertedValue;
        }
    }
}
