using System;
using System.Collections;

namespace hoge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Hello!");

            Console.WriteLine(((string)list[0]).ToUpper());
        }
    }
}
