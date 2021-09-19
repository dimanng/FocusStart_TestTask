using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStart_TestTask
{
    public class SortNumbersByIncrease : ISorting
    {        
        private int[] SortByIncrease(int[] listNumbers, int[] sortedList)
        {
            if (!SortNumber.isSortedNumberByIncrease(listNumbers))
            {
                SortNumber.PreSortByIncrease(listNumbers);
            }

            if (sortedList.Length == 0)
            {
                return listNumbers;
            }

            return SortNumber.SortByIncrease(sortedList, listNumbers);
        }

        public ArrayList Sort(ArrayList linesFromFile, ArrayList sortedList)
        {
            int[] listNumbers = Converter.ConvertToInt32(linesFromFile);
            int[] sortedList1 = Converter.ConvertToInt32(sortedList);
            return new ArrayList(SortByIncrease(listNumbers, sortedList1));
        }
    }
}
