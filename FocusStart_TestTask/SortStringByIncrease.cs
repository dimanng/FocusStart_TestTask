using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStart_TestTask
{
    class SortStringByIncrease : ISorting
    {
        private string[] SortByIncrease(string[] listString, string[] sortedList)
        {
            if (!SortString.isSortedStringByIncrease(listString))
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
            return new ArrayList(SortByIncrease(listString, sortedList1));
        }

        

    }
}
