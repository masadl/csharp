using System;
using System.Collections.Generic;

class Sample
{
  public IEnumerator<char> GetEnumerator() {
    Console.Write("[Cを返す]");
    yield return 'C';

    Console.Write("[yield break実行]");
    yield break;

    Console.Write("[#を返す]");
    yield return '#';
  }
}

class Program
{
  static void Main(string[] args) {
    foreach (char c in new Sample())
    {
      Console.Write("{0} ", c);
    }
  }
}