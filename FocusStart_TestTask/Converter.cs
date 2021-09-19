using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStart_TestTask
{
    class Converter
    {
        public static int[] ConvertToInt32(ArrayList strString)
        {
            int[] str = new int[strString.Count];

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Convert.ToInt32(strString[i]);
            }
            return str;
        }

        public static string[] ConvertToStringArray(ArrayList linesFromFile)
        {
            return (string[])linesFromFile.ToArray(typeof(string));
        }

    }
}
