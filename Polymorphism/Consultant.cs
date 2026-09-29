using System;

namespace Polymorphism;

public class Consultant : Person
{
    public decimal HourlyRate { get; set; }
    public string ConsultingFirm { get; set; }

    public void GiveAdvice()
    {
        Console.WriteLine("Konsulten ger sin expertis till hotellet.");
    }
}
