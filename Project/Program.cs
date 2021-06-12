using System;
using System.Globalization;

namespace DataStructuresAlgorithms.Project
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
            var callds = new CallDataStructures();
            callds.CallArray();
            callds.CallArrayList();
            callds.CallList();
            callds.CallHashtableExample();
            callds.CallLinkedList();
            callds.CallQueue();
            callds.Callstack();
        }

        public static void Hacker()
        {
            HackerRank hp = new HackerRank();
            // Console.WriteLine(Hp.PairSums() ? "Yes" : "No");
            hp.CheckIfduplicateExsist();
            hp.FindDuplicates();
            hp.InsertNodeLinkedList();
            hp.BubbleSort();
            hp.QuickSort();
            hp.FibonacciExample();

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
