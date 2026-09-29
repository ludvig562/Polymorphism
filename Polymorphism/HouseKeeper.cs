using System;

namespace Polymorphism;

public class HouseKeeper : Employee
{
    public enum CleaningSpeed
    {
        Fast,
        Average,
        Thorough
    }
    public Dictionary<string, int>{ get; set; }
    public List<string> SpecialtyAreas;
    public override void DoWork()
    {
        Console.WriteLine("Hotellstädaren städar hotellrummen.");
    }
}
