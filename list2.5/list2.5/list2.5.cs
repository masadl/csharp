using System;
using System.Collections.Generic;

// インタフェースの定義
public interface ISample
{
    void SayISample();
}

// 抽象クラスの定義
public abstract class SampleBase
{
    public abstract void SaySample();
}

// SampleBaseクラスを継承し，ISampleインタフェースを実装したクラス
public class Sample : SampleBase, ISample
{
    public override void SaySample()
    {
        Console.WriteLine("Sample!");
    }

    public void SayISample()
    {
        Console.WriteLine("ISample!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // SampleBase型のコレクションにSampleオブジェクトを追加
        List<SampleBase> list1 = new List<SampleBase>();
        list1.Add(new Sample());

        list1[0].SaySample(); // 出力：Sample!

        // ISample型のコレクションにSampleオブジェクトを追加
        List<ISample> list2 = new List<ISample>();
        list2.Add(new Sample());

        list2[0].SayISample(); // 出力：ISample!
    }
}