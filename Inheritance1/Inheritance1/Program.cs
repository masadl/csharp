using System;

abstract class Bicycle
{
    public string Size { get; private set; }
    public string Chain { get; private set; }
    public string TireSize { get; private set; }

    // Member variables cannot be overrided, though properties can.
    public virtual string DefaultTireSize { get; protected set; }

    private const string DefaultChain = "10-speed";

    public Bicycle(string size,
                   string tireSize = null,
                   string chain = DefaultChain)
    {
        Size = size;
        Chain = chain;
        // Since only const expression are available for default values, 
        // I used null coalescing operator instead.
        TireSize = tireSize ?? DefaultTireSize;
    }

    // Spares メソッドはここでは略
}


class RoadBike : Bicycle
{
    public RoadBike(string size = null,
                    string tapeColor = null,
                    string frontShock = null,
                    string rearShock = null) : base(size, tapeColor)
}


class MountainBike : Bicycle
{
    public string FrontShock { get; private set; }
    public string RearShock { get; private set; }

    public override string DefaultTireSize { get; protected set; } = "2.1";

    public MountainBike(string size = null,
                        string tapeColor = null,
                        string frontShock = null,
                        string rearShock = null) : base(size, tapeColor)
    {
        FrontShock = frontShock;
        RearShock = rearShock;
    }
}


class MainClass
{
    public static void Main(string[] args)
    {
        var mountainBike = new MountainBike(size: "S",
                                           frontShock: "Manitou",
                                            rearShock: "Fox");
        Console.WriteLine(mountainBike.Size);    // => S
    }
}