using System;

namespace Polymorphism;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string EmployeeId { get; set; }
    public DateTime StartDate { get; set; }
    public decimal Salary { get; set; }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Namn: {Name}, Ålder: {Age}.");
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Hej jag heter {Name} och är {Age} år gammal.");
    }
    public virtual void DoWork()
    {
        Console.WriteLine("ARBETSLÖS");
    }
}

