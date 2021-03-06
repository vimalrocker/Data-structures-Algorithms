﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace DataStructuresAlgorithms.Project
{
    /// <summary>
    /// Linear time
    /// Constant Time
    /// quadratic time complexity 
    /// </summary>
    public class HackerRank
    {
        //Check an array to see if there is pair that when added returns a given Sum
        public bool PairSums()
        {
            int n = 5;
            int sum = 6;
            int[] arr = new int[] { 1, 5, 7, -1, 5 };
            bool issumthere = false;
            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        issumthere = true;
                        return issumthere;
                    }
                }
            }

            return issumthere;

        }

        //Check two string to find if a common char is present using HashSet 
        public string TwoStrings()
        {
            var s1 = "hello";
            var s2 = "world";

            var chars1 = new HashSet<char>(s1.ToList());
            var chars2 = s2.ToList();

            foreach (var x in chars2)
            {
                if (chars1.Contains(x))
                {
                    return "Yes";
                }
            }

            return "No";
        }

        public string FibonacciExample()
        {
            int n1 = 0 ,n2 = 1 ,n3;
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < 20; i++)
            {
                n3 = n1 + n2;
                sb.Append(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            return sb.ToString();
        }

        public string RansomNote()
        {
            var mag = "two times three is not four";
            var not = "two times two is four";
            string[] magazine = mag.Split(' ');
            string[] note = not.Split(' ');

            bool allAvailable = true;

            var hasmagazine = new Hashtable();

            foreach (var item in magazine)
            {
                if (!hasmagazine.Contains(item))
                {
                    hasmagazine.Add(item, 1);
                }
                else
                {
                    hasmagazine[item] = (int)hasmagazine[item] + 1;
                }
            }

            foreach (var item in note)
            {
                if (!hasmagazine.Contains(item))
                {
                    allAvailable = false;
                }

                else
                {
                    if ((int)hasmagazine[item] == 1)
                    {
                        hasmagazine.Remove(item);
                    }
                    else
                    {
                        hasmagazine[item] = (int)hasmagazine[item] - 1;
                    }
                }
            }


            return allAvailable ? "Yes" : "No";
        }

        public bool CheckIfduplicateExsist()
        {
            string[] names = new string[] {
                "mahesh",
                "vikram",
                "mayur",
                "suprotim",
                "saket",
                "manish"
            };

            var hasset = new HashSet<string>(names);
            return names.Length == hasset.Count;
        }


        public string[] FindDuplicates()
        {
            var arr = new string[] { "6", "1", "2", "4", "6", "5", "1" };
            var duplicated = arr.GroupBy(x => x).Where(y => y.Count() > 1).Select(z => z.Key).ToArray();
            return duplicated;
        }
        public string[] FindDuplicatesInString()
        {
            string[] names = new string[] {
                "mahesh",
                "vikram",
                "mayur",
                "suprotim",
                "saket",
                "manish",
                "mahesh"
            };
            var duplicated = names.GroupBy(x => x).Where(y => y.Count() > 1).Select(z => z.Key).ToArray();
            return duplicated;
        }

        public int[] Leftrotation()
        {
            int n = 4;
            var arr = new int[] { 1, 2, 3, 4, 5 };

            var list = arr.ToList();
            for (int i = 0; i < n; i++)
            {
                var temp = list.First();
                list.Remove(temp);
                list.Add(temp);

            }

            return list.ToArray();
        }

        public void InsertNodeLinkedList()
        {
            var linkedlist = new LinkedList<int>();

            var arr = new int[] { 0, 6, 2, 19, 7, 4, 15, 9 };

            for (int i = 0; i < 5; i++)
            {
                linkedlist.AddLast(arr[i]);
            }

            linkedlist = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                linkedlist.AddFirst(arr[i]);
            }


            arr = new int[] { 0, 6, 2, 19, 7, 4, 15, 9 };

            linkedlist = new LinkedList<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                linkedlist.AddLast(arr[i]);
            }

            var nodeindex = 3;
            var index = 0;
            var iteminsidelist = 0;
            foreach (var item in linkedlist)
            {
                if (index == nodeindex)
                {
                    iteminsidelist = item;
                     break;
                }

                index++;
            }

            linkedlist.Remove(iteminsidelist);
        }


        #region Sorting Techniques

        public int BubbleSort()
        {
            int[] arr = { 3, 2, 1 };
            var swapcount = 0;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        swapcount++;
                    }
                }
            }
            return swapcount;
        }


        public void QuickSort()
        {
            int[] iInput = {4, 3, 1, 4, 6, 7, 5, 4, 32, 5, 26, 187, 8};
            QuickSortNow(iInput, 0, iInput.Length - 1);

        }

        public void QuickSortNow( int[] array,int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(array, start, end);
                QuickSortNow(array, start, pivot - 1);
                QuickSortNow(array, pivot + 1, end);
            }
        }
        public static int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    int temp = array[i];
                    array[i] = array[pIndex];
                    array[pIndex] = temp;
                    pIndex++;
                }
            }

            int anotherTemp = array[pIndex];
            array[pIndex] = array[end];
            array[end] = anotherTemp;
            return pIndex;
        }
   

        public void HeapSort()
        {

        }

        public void MergeSort()
        {

        }

        #endregion  

    }
}
