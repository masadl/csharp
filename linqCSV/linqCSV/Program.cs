using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linqCSV
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      var persons = new[] {
        new {Name = "Tom", Age = 17},
        new {Name = "Ken", Age = 46},
        new {Name = "Alice", Age = 18},
        new {Name = "Mike", Age = 19},
        new {Name = "John", Age = 23},
      };

      foreach (var name in 
               from person in persons select person.Name)
        Console.WriteLine("Name: " + name);
    }
  }
}
