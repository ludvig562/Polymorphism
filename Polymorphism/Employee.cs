using System;

namespace Polymorphism;

public class Employee : Person
{
    public string Department { get; set; }
    public string JobTitle { get; set; }

    public void Work()
    {
        Console.WriteLine($"{Name} jobbar jätte mycket.");
    }
}
