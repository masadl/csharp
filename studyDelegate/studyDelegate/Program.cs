using System;
namespace studyDelegate
{
  class Program
  {
    private delegate void DelegateFunc(string _w);

    static void Main(string[] args) {
      string word;
      word = "hello";

      DelegateFunc myFunc;
      myFunc = SayWord;
      myFunc += SayWordWord; 

      myFunc(word);
    }

    private static void SayWord(string word) {
      Console.WriteLine(word);
    }

    private static void SayWordWord(string word) {
      word = word + word;
      Console.WriteLine(word);
    }
  }
}
