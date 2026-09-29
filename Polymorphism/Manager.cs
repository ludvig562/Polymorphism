using System;

namespace Polymorphism;

public class Manager : Person
{
    public string Department { get; set; }

    public void HoldMeeting()
    {
        Console.WriteLine("Chefen håller ett personalmöte på hotellet.");
    }
}
