using System;

namespace Polymorphism;

public class HouseKeeper : Employee
{
    public override void DoWork()
    {
        Console.WriteLine("Hotellstädaren städar hotellrummen.");
    }
}
