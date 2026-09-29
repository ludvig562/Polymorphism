using System;


namespace Polymorphism;

public class Consultant : Person
{
    public decimal HourlyRate { get; set; }
    public string ConsultingFirm { get; set; }
    public string Expertise { get; set; }

    public void GiveAdvice()
    {
        Console.WriteLine($"Konsulten ger sin {Expertise} expertis till hotellet.");
    }
    public override void DoWork()
    {
        Console.WriteLine("Konsulten ger strategiska råd om hotellsäkerhet.");
    }
}
