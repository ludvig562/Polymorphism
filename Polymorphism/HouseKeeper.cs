using System;

namespace Polymorphism;

public class HouseKeeper : Employee
{
    public override void Work()
    {
        Console.WriteLine($"{Name} städar rummet.");
    }
}
