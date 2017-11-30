using System;

/* IComparableはCompareToメソッドのみをもつインタフェース
 * ジェネリッククラスのオブジェクトの比較を行うためのインタフェース
 */

public class ClassA : IComparable<ClassA>
{
    public int Value;
    public ClassA(int v) {
        Value = v;
    }

    public int CompareTo(ClassA other) {
        return Value.CompareTo(other.Value);
    }
}

public class ClassB : ClassA, IComparable<ClassB>
{
    public ClassB(int v) : base(v) {}

    public int CompareTo(ClassB other) {
        return other.Value.CompareTo(Value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClassB[] array = {
            new ClassB(3),
            new ClassB(2),
            new ClassB(1)
        };

        Array.Sort<ClassA>(array);
        foreach (ClassB b in array) {
            Console.WriteLine(b.Value);
        }

        Array.Sort<ClassB>(array);
        foreach (ClassB b in array) {
            Console.WriteLine(b.Value);
        }

    }
}