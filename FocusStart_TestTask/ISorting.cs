using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStart_TestTask
{
    interface ISorting
    {
        //public int[] Sort(int[] listNumbers, int[] sortedList);
        ArrayList Sort(ArrayList linesFromFile, ArrayList sortedList);
    }
}
