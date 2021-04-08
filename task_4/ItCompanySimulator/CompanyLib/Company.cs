using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class Company : ICompany
    {
        private string _idea;
        private int _budget;
        private int _salary;
        private Employee _participantCreator;
        private List<Employee> _team;
        private List<IClient> _clients;
        public int Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Company(Employee participantCreator, string idea, int budget, List<Employee> team, int salary)
        {
            _participantCreator = participantCreator;
            _idea = idea;
            Budget = budget;
            _team = team;
            Salary = salary;
            _clients = new List<IClient>();

            participantCreator.SetCompany(this);
            foreach(IEmployee participant in team)
            {
                participant.SetCompany(this);
            }
        }

        public void Advertise(int adBudget)
        {
            if (Budget - adBudget > 0)
            {
                Budget -= adBudget;
            } else
            {
                Console.WriteLine("Too little money");
            }
        }
        public void AddParticipant(Employee participant)
        {
            _team.Add(participant);
            participant.SetCompany(this);
        }
        public void SetSalary(int salary)
        {
            Salary = salary;
        }
        public void AddClient(IClient client)
        {
            _clients.Add(client);
            client.Company = this;
        }

    }
}
