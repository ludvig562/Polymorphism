namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // Skapa en Manager
            // Manager manager = new Manager
            // {
            //     Name = "Lisa Ledarsson",
            //     Age = 40,
            //     EmployeeId = "M001",
            //     StartDate = new DateTime(2020, 1, 1),
            //     Salary = 50000m,
            //     Department = "Administration"
            // };

            // // Skapa en Employee
            // Employee employee = new Employee
            // {
            //     Name = "Erik Eriksson",
            //     Age = 30,
            //     EmployeeId = "E001",
            //     StartDate = new DateTime(2022, 3, 15),
            //     Salary = 30000m,
            //     JobTitle = "Receptionist",
            //     Department = "Front Desk"
            // };


            // // Anropa metoder för att testa
            // Console.WriteLine("Manager:");
            // manager.PrintInfo();
            // manager.Introduce();
            // manager.HoldMeeting();
            // manager.PlanBudget();

            // Console.WriteLine("\nEmployee:");
            // employee.PrintInfo();
            // employee.Introduce();
            // employee.Work();


            // Consultant consultant = new Consultant
            // {
            //     Name = "Eva Expert",
            //     Age = 35,
            //     EmployeeId = "C001",
            //     StartDate = new DateTime(2023, 1, 1),
            //     Salary = 0, // Konsulter har ofta inte fast lön
            //     HourlyRate = 1000,
            //     ConsultingFirm = "Hotell Experterna AB",
            //     Expertise = "städning och underhåll"
            // };

            // Console.WriteLine("\nConsultant:");
            // consultant.PrintInfo();
            // consultant.Introduce();
            // consultant.GiveAdvice();
            // Console.WriteLine($"Hourly Rate: {consultant.HourlyRate}");
            // Console.WriteLine($"Consulting Firm: {consultant.ConsultingFirm}");


            // HouseKeeper houseKeeper = new HouseKeeper();
            // houseKeeper.Name = "Anna Clean";
            // houseKeeper.Age = 31;
            // Console.WriteLine();
            // houseKeeper.PrintInfo();
            // houseKeeper.Work();


            List<Person> hotelStaff = new List<Person>();

            hotelStaff.Add(new Manager { Name = "Maria Svensson", Age = 45, EmployeeId = "M002", Department = "Operations", Salary = 55000m, StartDate = new DateTime(2018, 5, 1) });
            hotelStaff.Add(new Employee { Name = "Johan Andersson", Age = 28, EmployeeId = "E002", JobTitle = "Receptionist", Department = "Front Desk", Salary = 32000m, StartDate = new DateTime(2021, 9, 15) });
            hotelStaff.Add(new Consultant { Name = "Sara Lindberg", Age = 38, EmployeeId = "C002", ConsultingFirm = "Hotell Konsulterna AB", HourlyRate = 1200m, StartDate = new DateTime(2023, 3, 1) });
            hotelStaff.Add(new Employee { Name = "Kalle Persson", Age = 33, EmployeeId = "E003", JobTitle = "Kock", Department = "Kök", Salary = 35000m, StartDate = new DateTime(2020, 11, 1) });
            hotelStaff.Add(new Manager { Name = "Eva Karlsson", Age = 50, EmployeeId = "M003", Department = "HR", Salary = 58000m, StartDate = new DateTime(2015, 2, 1) });

            Console.WriteLine("Hotellets personal:");
            foreach (var person in hotelStaff)
            {
                person.PrintInfo();
                person.Introduce();

                if (person is Manager manager)
                {
                    manager.HoldMeeting();
                    manager.DoWork();
                }
                else if (person is Employee employee)
                {
                    employee.Work();
                    employee.DoWork();
                }
                else if (person is Consultant consultant)
                {
                    consultant.GiveAdvice();
                    consultant.DoWork();
                }

                Console.WriteLine();
            }

            double averageAge = hotelStaff.Average(p => p.Age);
            decimal totalSalary = hotelStaff.Sum(p => p.Salary);

            Console.WriteLine($"Genomsnittlig ålder på personalen: {averageAge:F1} år");
            Console.WriteLine($"Total månadslön för anställda: {totalSalary:C}");


            //Test 
        }
    }
}
