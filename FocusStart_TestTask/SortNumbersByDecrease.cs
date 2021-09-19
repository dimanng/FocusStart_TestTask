using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStart_TestTask
{
    class SortNumbersByDecrease : ISorting
    {
        private int[] SortByDecrease(int[] listNumbers, int[] sortedList)
        {
            if (!SortNumber.isSortedNumberByDecrease(listNumbers))
            {
                SortNumber.PreSortByDecrease(listNumbers);
            }

            if (sortedList.Length == 0)
            {
                return listNumbers;

            }

            return SortNumber.SortByDecrease(sortedList, listNumbers);
        }
        public ArrayList Sort(ArrayList linesFromFile, ArrayList sortedList)
        {
            int[] listNumbers = Converter.ConvertToInt32(linesFromFile);
            int[] sortedList1 = Converter.ConvertToInt32(sortedList);
            return new ArrayList(SortByDecrease(listNumbers, sortedList1));
        }
    }
    
}
