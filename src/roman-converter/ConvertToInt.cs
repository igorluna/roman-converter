using System;
using System.Collections.Generic;

namespace roman_converter
{

    public static class ConvertToInt
    {
        private static Dictionary<string,int> romanValues = new Dictionary<string, int>{
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000},
        };

        public static int ToInt(this string roman)
        {
            if(romanValues.TryGetValue(roman, out int value))
            {
                return value;
            }
            
            throw new NotImplementedException();
        }
    }
}
