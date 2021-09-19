using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
namespace FocusStart_TestTask
{
    class Program
    {      
        public void Merge(ArrayList arrFiles, ISorting sorter)
        {
            ArrayList sortedList = new ArrayList();

            string pathOut = arrFiles[0].ToString();

            for (int i = 1; i < arrFiles.Count; i++)
            {
                string pathIn = arrFiles[i].ToString();

                ArrayList linesFromFile = FileHelper.ReadLinesFromFile(pathIn);              

                sortedList = sorter.Sort(linesFromFile, sortedList);
            }

            FileHelper.WriteLinesToFile(sortedList, pathOut);
        }

        
        static void Main(string[] args)
        {          
            ArrayList arrArgs = new ArrayList();

            ArrayList arrFiles = new ArrayList();

            Program pr1 = new Program();

            foreach (string e in args)
            {
                if (Regex.IsMatch(e, @"-(\w*)"))
                {
                    arrArgs.Add(e);
                }
                if (Regex.IsMatch(e, @"\w*\.\w*"))
                {
                    arrFiles.Add(e);
                }
            }

            if (arrArgs.Contains("-i"))
            {
                if (arrArgs.Contains("-a"))
                {
                    pr1.Merge(arrFiles, new SortNumbersByIncrease());

                }
                else if (arrArgs.Contains("-d"))
                {
                    pr1.Merge(arrFiles, new SortNumbersByDecrease());
                }
                else
                {
                    pr1.Merge(arrFiles, new SortNumbersByIncrease());
                }
            }
            else if (arrArgs.Contains("-s"))
            {
                if (arrArgs.Contains("-a"))
                {
                    pr1.Merge(arrFiles, new SortStringByIncrease());
                }
                else if (arrArgs.Contains("-d"))
                {
                    pr1.Merge(arrFiles, new SortStringByDecrease());
                }
                else
                {
                    pr1.Merge(arrFiles, new SortStringByIncrease());
                }
            }
            
            Console.ReadKey();
        }
    }
}
