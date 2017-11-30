using System;

class Program
{
    static void Main(string[] args) {
        int[] array = { 3, 2, 1 };
        Array.Sort<int>(array); // ジェネリックメソッドの呼び出し

        foreach (int i in array) {
            Console.WriteLine(i);
        }
    }
}