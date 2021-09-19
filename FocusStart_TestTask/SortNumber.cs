using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStart_TestTask
{
    class SortNumber
    {
        public static bool isSortedNumberByIncrease(int[] arr)
        {
            bool res = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    res = false;
                }
            }
            return res;
        }
        public static bool isSortedNumberByDecrease(int[] arr)
        {
            bool res = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] <= arr[i + 1])
                {
                    res = false;
                }
            }
            return res;
        }

        public static void PreSortByIncrease(int[] arr)
        {
            ////пузырек
            
            if (arr.Length <= 1)
            {
                return;
            }

            int[] arr1 = new int[arr.Length / 2];
            int[] arr2 = new int[arr.Length - arr.Length / 2];

            Array.Copy(arr, 0, arr1, 0, arr1.Length);
            Array.Copy(arr, arr1.Length, arr2, 0, arr2.Length);

            PreSortByIncrease(arr1);
            PreSortByIncrease(arr2);

            SortByIncrease(arr, arr1, arr2);

        }
        
        public static int[] SortByIncrease(int[] arr1, int[] arr2)
        {
            int[] arrRes = new int[arr1.Length + arr2.Length];
            SortByIncrease(arrRes, arr1, arr2);
            return arrRes;
        }

        public static void SortByIncrease(int[] arrRes, int[] arr1, int[] arr2)
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
                else if (arr1[i] < arr2[j])
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
        public static void PreSortByDecrease(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return;
            }

            int[] arr1 = new int[arr.Length / 2];
            int[] arr2 = new int[arr.Length - arr.Length / 2];

            Array.Copy(arr, 0, arr1, 0, arr1.Length);
            Array.Copy(arr, arr1.Length, arr2, 0, arr2.Length);

            PreSortByDecrease(arr1);
            PreSortByDecrease(arr2);

            SortByDecrease(arr, arr1, arr2);

        }

        public static int[] SortByDecrease(int[] arr1, int[] arr2)
        {
            int[] arrRes = new int[arr1.Length + arr2.Length];
            SortByDecrease(arrRes, arr1, arr2);
            return arrRes;
        }
        public static void SortByDecrease(int[] arrRes, int[] arr1, int[] arr2)
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
                else if (arr1[i] > arr2[j])
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

        /// <summary>
        /// Эксперименты с сортировкой коллекций ArrayList
        /// </summary>
        /// <param name="arr"></param>
        /// 
        /*
        public static void PreSortByIncrease(ArrayList arr)
        {
            if (arr.Count <= 1)
            {
                return;
            }
            lock (arr) ;
            ArrayList arr1 = new ArrayList();
            ArrayList arr2 = new ArrayList();
            lock (arr1) ;
            lock (arr2) ;
            int l1 = arr.Count / 2;
            int l2 = arr.Count - l1;

            arr1 = arr.GetRange(0, l1);
            arr2 = arr.GetRange(l1, l2);
            /*
            Array.Copy(arr, 0, arr1, 0, arr1.Count);
            Array.Copy(arr, arr1.Count, arr2, 0, arr2.Count);
            */
      /*      PreSortByIncrease(arr1);
            PreSortByIncrease(arr2);

            SortByIncrease(arr, arr1, arr2);

        }
      */
      /*
        public static void SortByIncrease(ArrayList arrRes, ArrayList arr1, ArrayList arr2)
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
                else if (Convert.ToInt32(arr1[i]) < Convert.ToInt32(arr2[j]))
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
        }*//*
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
                else if (Convert.ToInt32(arr1[i]) >= Convert.ToInt32(arr2[j]))
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
        }*/

    }
}
