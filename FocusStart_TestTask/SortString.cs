using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStart_TestTask
{
    class SortString
    {
        public static bool isSortedStringByIncrease(string[] arr)
        {
            bool res = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    res = false;
                }
            }
            return res;
        }
        public static bool isSortedStringByDecrease(string[] arr)
        {
            bool res = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) <= 0)
                {
                    res = false;
                }
            }
            return res;
        }

        public static void PreSortByIncrease(string[] arr)
        {
            if (arr.Length <= 1)
            {
                return;
            }

            string[] arr1 = new string[arr.Length / 2];
            string[] arr2 = new string[arr.Length - arr.Length / 2];

            Array.Copy(arr, 0, arr1, 0, arr1.Length);
            Array.Copy(arr, arr1.Length, arr2, 0, arr2.Length);

            PreSortByIncrease(arr1);
            PreSortByIncrease(arr2);

            SortByIncrease(arr, arr1, arr2);

        }

        public static string[] SortByIncrease(string[] arr1, string[] arr2)
        {
            string[] arrRes = new string[arr1.Length + arr2.Length];
            SortByIncrease(arrRes, arr1, arr2);
            return arrRes;
        }

        public static void SortByIncrease(string[] arrRes, string[] arr1, string[] arr2)
        {
            int i = 0;
            int j = 0;
            for (int k = 0; k < arrRes.Length; k++)
            {

                if (i > arr1.Length - 1)
                {
                    arrRes[k] = arr2[j];
                    j++;
                }
                else if (j > arr2.Length - 1)
                {
                    arrRes[k] = arr1[i];
                    i++;
                }
                else if (arr1[i].CompareTo(arr2[j]) < 0)
                {
                    arrRes[k] = arr1[i];
                    i++;
                }
                else
                {
                    arrRes[k] = arr2[j];
                    j++;
                }
            }
        }
        

        public static void PreSortByDecrease(string[] arr)
        {
            if (arr.Length <= 1)
            {
                return;
            }

            string[] arr1 = new string[arr.Length / 2];
            string[] arr2 = new string[arr.Length - arr.Length / 2];

            Array.Copy(arr, 0, arr1, 0, arr1.Length);
            Array.Copy(arr, arr1.Length, arr2, 0, arr2.Length);

            PreSortByDecrease(arr1);
            PreSortByDecrease(arr2);

            SortByDecrease(arr, arr1, arr2);

        }

        public static string[] SortByDecrease(string[] arr1, string[] arr2)
        {
            string[] arrRes = new string[arr1.Length + arr2.Length];
            SortByDecrease(arrRes, arr1, arr2);
            return arrRes;
        }

        public static void SortByDecrease(string[] arrRes, string[] arr1, string[] arr2)
        {
            int i = 0;
            int j = 0;
            for (int k = 0; k < arrRes.Length; k++)
            {

                if (i > arr1.Length - 1)
                {
                    arrRes[k] = arr2[j];
                    j++;
                }
                else if (j > arr2.Length - 1)
                {
                    arrRes[k] = arr1[i];
                    i++;
                }
                else if (arr1[i].CompareTo(arr2[j]) > 0)
                {
                    arrRes[k] = arr1[i];
                    i++;
                }
                else
                {
                    arrRes[k] = arr2[j];
                    j++;
                }
            }
        }
        /*
        public static void SortByDecrease(ArrayList arrRes, ArrayList arr1, ArrayList arr2)
        {
            int i = 0;
            int j = 0;
            int length = arr1.Count + arr2.Count;
            for (int k = 0; k < length; k++)
            {

                if (i > arr1.Count - 1)
                {
                    arrRes.Add(arr2[j]);
                    j++;
                }
                else if (j > arr2.Count - 1)
                {
                    arrRes.Add(arr1[i]);
                    i++;
                }
                else if ((arr1[i].ToString()).CompareTo((arr2[j]).ToString()) > 0)
                {
                    arrRes.Add(arr1[i]);
                    i++;
                }
                else
                {
                    arrRes.Add(arr2[j]);
                    j++;
                }
            }
        }
        
        public static void SortByIncrease(ArrayList arrRes, ArrayList arr1, ArrayList arr2)
        {
            int i = 0;
            int j = 0;
            int length = arr1.Count + arr2.Count;
            for (int k = 0; k < length; k++)
            {

                if (i > arr1.Count- 1)
                {
                    arrRes.Add(arr2[j]);
                    j++;
                }
                else if (j > arr2.Count - 1)
                {
                    arrRes.Add(arr1[i]);
                    i++;
                }
                else if ((arr1[i].ToString()).CompareTo((arr2[j]).ToString()) < 0)
                {
                    arrRes.Add(arr1[i]);
                    i++;
                }
                else
                {
                    arrRes.Add(arr2[j]);
                    j++;
                }
            }
        }
         
         */
    }
}
