using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStart_TestTask
{
    class SortStringByDecrease : ISorting
    {
        public string[] SortByDecrease(string[] listString, string[] sortedList)
        {
            if (!SortString.isSortedStringByDecrease(listString))
            {
                SortString.PreSortByIncrease(listString);
            }

            if (sortedList.Length == 0)
            {
                return listString;

            }

            return SortString.SortByIncrease(sortedList, listString);
        }

        public ArrayList Sort(ArrayList linesFromFile, ArrayList sortedList)
        {
            string[] listString = Converter.ConvertToStringArray(linesFromFile);
            string[] sortedList1 = Converter.ConvertToStringArray(sortedList);
            return new ArrayList(SortByDecrease(listString, sortedList1));
        }
    }
}
