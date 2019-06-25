using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Project
{
    /// <summary>
    /// Different DataStructures in C#  
    /// Array, ArrayList,List
    /// Dictionary, HashTable, HashSet,
    /// LinkedList, Stack, Queue
    /// </summary>
    public class DataStructures
    {
        /// <summary>
        /// Collections of the same data type
        /// Fixed Size cant accept null
        /// Access the Array elements by numeric index
        /// The default value of numeric array elements is set to zero
        /// 
        /// </summary>
        /// <returns></returns>
        public int[] ArrayExample()
        {
            // datatype[] arrayName = new datatype[size];
            int[] intarray = new int[5] { 0, 1, 2, 3, 4 };
            return intarray;
        }

        /// <summary>
        /// Collections of the different data type
        /// Can store the values of different data types or same data type
        /// Dynamic Size and accepts null
        /// 
        /// </summary>
        /// <returns></returns>
        public ArrayList ArrayListExample()
        {
            var arrayList = new ArrayList { 1, "string", 1.522, null };
            return arrayList;
        }

        /// <summary>
        /// Generic Collection
        /// </summary>
        /// <returns></returns>
        public List<string> ListExample()
        {
            var listOfString = new List<string> { "Test", "Test2", "Test3" };
            return listOfString;


        }
        /// <summary>
        /// A LinkedList Node has basically three values: the Object's Value, a reference to the Next node, and a reference to the Previous Node.
        /// Adding values to the middle of the LinkedList is much faster 
        /// </summary>
        /// <returns></returns>
        public LinkedList<int> LinkedListExample()
        {
            var linkedList = new LinkedList<int>();
            var node = linkedList.AddFirst(1);
            linkedList.AddLast(6);
            linkedList.AddAfter(node, 5);
            return linkedList;
        }

        /// <summary>
        /// Dictionary is generic type Dictionary [Key,Value]
        /// Dictionary class is a strong type [Key,Value]  Hence, you must specify the data types for key and value.
        /// There is no need of boxing/unboxing.
        /// When you try to access non existing key dictionary, it gives runtime error.
        /// Dictionary maintains an order of the stored values.
        /// There is no need of boxing/unboxing, so it is faster than Hashtable.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> DictionaryExample()
        {
            var dictionary = new Dictionary<int, string> { { 1, "test1" }, { 2, "test2" }, { 3, "test3" } };
            return dictionary;
        }
        /// <summary>
        /// Hashtable is non-generic type.
        /// Hashtable is a weakly typed data structure, so you can add keys and values of any object type.
        /// Values need to have boxing/unboxing.
        /// When you try to access non existing key Hashtable, it gives null values.
        /// Hashtable never maintains an order of the stored values.
        /// Hashtable needs boxing/unboxing, so it is slower than Dictionary.
        /// </summary>
        /// <returns></returns>
        public Hashtable HashtableExample()
        {
            var hashtable = new Hashtable { { 1, "test1" }, { "a", "test2" }, { "3", 3 } };
            return hashtable;
        }
        /// <summary>
        /// Similar to list only main difference  it will ignore  duplicate values
        /// Designed to allow fast search times which dramatically improves the performance of checking whether a new element is a duplicate or not
        /// </summary>
        /// <returns></returns>
        public HashSet<string> HashSetExample()
        {
            var hashSet = new HashSet<string> { "one", "one", "Two" };
            return hashSet;
        }

        /// <summary>
        /// Follows First-In-First-Out.
        /// Enqueue to add Dequeue to view 
        /// </summary>
        /// <returns></returns>
        public Queue QueueExample()
        {
            var queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("one");
            queue.Enqueue(2);
            queue.Enqueue("two");
            return queue;
        }

        /// <summary>
        /// Follows Last-In-First-Out.
        /// Push to add and pop to move 
        /// </summary>
        /// <returns></returns>
        public Stack StackExample()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push("two");
            stack.Push(3);
            stack.Push("four");

            return stack;
        }


    }



}
