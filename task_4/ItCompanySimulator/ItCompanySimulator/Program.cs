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

            GoodClient Honda = new GoodClient();
            BadClient KupiVIP = new BadClient();
            ispring.AddClient(Honda);
            ispring.AddClient(KupiVIP);

            Honda.GiveFeedback();
            KupiVIP.GiveFeedback();

            programmer.GetSalary();
        }
    }
}
