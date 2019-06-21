using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresAlgorithms
{
    public class HackerRank
    {
        //
        public bool PairSums()
        {
            int n = 5;
            int sum = 6;
            var arr = new int[5] { 1, 5, 7, -1, 5 };
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

        //Check two string to find if a common element is present using HashSet 
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

        public void InsertNodeAtTailLinkedList()
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
            foreach (var item in linkedlist)
            {
                if (index == nodeindex)
                {
                    linkedlist.Remove(item);
                }

                index++;
            }
        }
    }
}
