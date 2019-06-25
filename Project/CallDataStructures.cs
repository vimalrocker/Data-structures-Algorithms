using System;
using System.Collections;
using System.Collections.Generic;
using DataStructuresAlgorithms.Project;

namespace DataStructuresAlgorithms.Project
{
    public class CallDataStructures
    {
        private DataStructures ds = new DataStructures();

        /// <summary>
        ///  This method will show how to
        ///  Iterate/loop through a Array and  Accessing Array
        ///  Change item in a  array
        ///  Reverse , Sort an array
        ///  Binary search on array
        ///  Resize array and add data
        /// </summary>
        public void CallArray()
        {
            var intarray = ds.ArrayExample();
            if (intarray == null) return;

            intarray[0] = 5;

            Array.Reverse(intarray);

            Array.Sort(intarray);

            foreach (var item in intarray)
            {

            }

            var indexofSearch = Array.BinarySearch(intarray, 5);
            Console.Write("Binary Search Array Index of 5 is :" + "{0}", indexofSearch + "\n");

            Array.Resize(ref intarray, 7);
            intarray[5] = 6;
            intarray[6] = 7;

            Console.Write("Resized Array length  :" + "{0}", PrintArray(intarray) + "\n");


            var newintarray = new int[intarray.Length];

            Array.Copy(intarray, newintarray, intarray.Length);

            Console.Write("Array Copied to new source:" + "{0}", PrintArray(newintarray) + "\n");


        }

        private string PrintArray(int[] intarray)
        {
            var tempdata = "";
            foreach (var item in intarray)
            {
                tempdata += item.ToString();
            }

            return tempdata;
        }

        /// <summary>
        ///  Check For null
        ///  Read from a list
        ///  Iterate/loop through a list  
        ///  Add Reverse Sort  List 
        /// </summary>
        public void CallList()
        {
            var list = ds.ListExample();

            var test = list[0];
            foreach (var item in list)
            {

            }

            list.Add("Test4");
            list.Reverse();
            list.Sort();
            int searresult = list.BinarySearch("Test4");

            var contains = list.Contains("Test3");

            list.AddRange(list);
            var list2 = list.ConvertAll(x => "A" + x);

            list2.Clear();


        }

        public void CallArrayList()
        {
            var arrayList = ds.ArrayListExample();
            var count = arrayList.Count;
        }

        public void CallHashtableExample()
        {
            var ht = ds.HashtableExample();
            ht.Add("", "");

            foreach (DictionaryEntry item in ht)
            {
                var key = item.Key;
                var val = item.Value;
            }

            ht.Remove("");
            var tets = ht[""];

        }

        public void CallHashSetExample()
        {
            var list = ds.ListExample();
            var ht = ds.HashSetExample();
        }


        public void CallLinkedList()
        {
            var linkedlist = ds.LinkedListExample();


            //Remove nth node 
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

            //Reverse linkedlist
            var reverescopyList = new LinkedList<int>();
            foreach (var i in linkedlist)
            {
                reverescopyList.AddFirst(i);
            }


        }


        public void Callstack()
        {
            var stack = ds.StackExample();
            var test = stack.Peek();
        }
    }
}
