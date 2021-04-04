using System;
using System.Collections.Generic;
using CompanyLib;

namespace ItCompanySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee founder  = new Employee("Yury Uskov", "CEO");
            Employee programmer = new Employee("Alexey Malov", "CTO");
            Employee designer = new Employee("Rinat Shayhutdinov", "Main designer");

            List<Employee> participants = new List<Employee>();
            participants.Add(programmer);
            participants.Add(designer);

            Company ispring = new Company(founder, "E-learning", 1, participants, 100);

            ispring.Advertise(100);
            designer.GetSalary();

            Client honda = new Client();
            Client kupivip = new Client();
            ispring.AddClient(honda);
            ispring.AddClient(kupivip);

            honda.PayMoney(10);
            honda.GiveFeedback();
            kupivip.GiveFeedback();

            programmer.GetSalary();
        }
    }
}
