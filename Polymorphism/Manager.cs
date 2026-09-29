using System;

namespace Polymorphism;

public class Manager : Person
{
    public string Department { get; set; }
    public int TeamSize { get; set; }
    public decimal BonusPercentage { get; set; }

    public enum ManagementLevel
    {
        Junior,
        Middle,
        Senior
    }
    public ManagementLevel Management { get; set; }

    public void HoldMeeting()
    {
        Console.WriteLine("Chefen håller ett personalmöte på hotellet.");
    }

    public void PlanBudget()
    {
        Console.WriteLine("Uf! Vad jobbigt.. nu måste jag planera hotellets budget.");
    }

    public override void DoWork()
    {
        Console.WriteLine("Chefen planerar och leder arbetet på avdelningen för lyxsviter.");
    }
}
