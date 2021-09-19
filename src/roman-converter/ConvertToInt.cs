using System;
using System.Collections.Generic;

namespace roman_converter
{

    public static class ConvertToInt
    {
        private static Dictionary<char,int> romanValues = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        public static int ToInt(this string roman)
        {
            int convertedValue = 0;
            foreach(var character in roman)
            {
                if(romanValues.TryGetValue(character, out int value))
                {
                    convertedValue += value;
                }
            }

            return convertedValue;
        }
    }
}
