using System;
using System.Globalization;
using DataStructuresAlgorithms.Project;

namespace DataStructuresAlgorithms
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Call();
            Test();
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

        public static void Test()
        {
            DateTime parsedDate;
            string status = "Active"; // Default
            if (DateTime.TryParse(ConvertDate("20200715", "yyyyMMdd", "MM/dd/yyyy"), out parsedDate)
                && parsedDate <= DateTime.Now)
            {

            }
        }

        protected static string ConvertDate(String localDate, String inFormat, String outFormat)
        {
            var myDtfi = new DateTimeFormatInfo();
            DateTime d;
            myDtfi.DateSeparator = String.Empty;
            myDtfi.FullDateTimePattern = inFormat; //"yyyyMMdd";

            if (DateTime.TryParseExact(localDate, inFormat, myDtfi, DateTimeStyles.None, out d) == false)
                return String.Empty;

            return d.ToString(outFormat); //"MMM-yyyy"
        }
    }
}
