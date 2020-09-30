using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            var test  = intarray.Max();
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


        public void CallArrayList()
        {
            var arrayList = ds.ArrayListExample();
            var count = arrayList.Count;
            arrayList.Reverse();
            arrayList.Remove(arrayList[0]);
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
            int i=0;
            // how to remove an item from a list
            foreach(var item in list.ToList())
            {
                if(item == "Test2")
                {
                    list.Remove(item);    
                }
            }
           
            list.Add("Test4");
            list.Add(null);
            list.Reverse();
            list.Sort();
            // list should be sorted to do binary search
            int searresult = list.BinarySearch("Test4");

            var contains = list.Contains("Test3");

            list.AddRange(list);
            var list2 = list.ConvertAll(x => "A" + x);
            list2.Remove("Test3");
            list2.RemoveAll(s => s.Equals("Test"));
            list2.Clear();

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
            
            var ht = ds.HashSetExample();
            var test = ht.Count();
            int[] arr = new int[ht.Count()];
        }


        public void CallLinkedList()
        {
            var linkedlist = ds.LinkedListExample();
            linkedlist.AddLast(9);
            linkedlist.AddLast(19);
            linkedlist.AddLast(21);
            // find middle node 

            var tets = linkedlist.ElementAt(linkedlist.Count/2);
 


            //Remove nth node 
            var nodeindex = 3;
            var index = 0;
            foreach (var item in linkedlist.ToList())
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

        public void CallQueue()
        {
            var queue = ds.QueueExample();
            queue.Enqueue(3);

            var Peek = queue.Peek();

            //Removes and returns an item from the beginning of the queue.
            var dequeue = queue.Dequeue();

            foreach (var item in queue)
            {

            }

            var contains = queue.Contains(1);
          
        }


        public void Callstack()
        {
            var stack = ds.StackExample();

            stack.Push(5);

            //	Returns the top item from the stack.
            var Peek = stack.Peek();

            //Removes and returns items from the top of the stack.
            var pop = stack.Pop();

            foreach (var item in stack)
            {

            }

            var contains = stack.Contains(5);
            stack.Clear();
        }



    }
}
