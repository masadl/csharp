using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) {
        DateTime start1 = DateTime.Now;
        for (int i = 0; i < 100; ++i) {
            List<string> list1 = new List<string>();
            list1.Add("First");
            list1.Add("Last");
            for (int j = 0; j < 10000; ++j) {
                list1.Insert(1, "Inserted");
            }
        }
        DateTime end1 = DateTime.Now;
        Console.WriteLine(end1 - start1);

        // LinkedListクラスの利用
        DateTime start2 = DateTime.Now;
        for (int i = 0; i < 100; ++i) {
            LinkedList<string> list2 = new LinkedList<string>();
            list2.AddLast("First");
            list2.AddLast("Last");
            for (int j = 0; j < 10000; ++j) {
                list2.AddAfter(list2.First, "Inserted");
            }
        }
        DateTime end2 = DateTime.Now;
        Console.WriteLine(end2 - start2);
    }
}