using System;
using DataStructuresAlgorithms.Project;

namespace DataStructuresAlgorithms
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Call();
            Console.ReadLine();
        }

        private static void Call()
        {
             //DataStructures();
              Hacker();
        }

        public static void DataStructures()
        {
            var sdsa = new CallDataStructures();
            sdsa.CallArray();
            sdsa.CallArrayList();
            sdsa.CallList();
            sdsa.CallHashtableExample();
            sdsa.CallLinkedList();
            sdsa.CallQueue();
            sdsa.Callstack();
        }

        public static void Hacker()
        {
            HackerRank Hp = new HackerRank();
            // Console.WriteLine(Hp.PairSums() ? "Yes" : "No");
            Hp.CheckIfduplicateExsist();
            Hp.FindDuplicates();
            Hp.InsertNodeLinkedList();
            Hp.BubbleSort();
            Hp.QuickSort();
            Hp.FibonacciExample();

        }
    }
}
