using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) {
        List<string> list = new List<string>();
        list.Add("Hello!");

        Console.WriteLine(list[0].ToUpper());
    }
}