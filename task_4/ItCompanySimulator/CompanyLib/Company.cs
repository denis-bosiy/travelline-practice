using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class Company : ICompany
    {
        public IEmployee creator;
        public string idea;
        int _budget;
        int _salary;
        private Employee participantCreator;
        private List<Employee> team;
        private List<IClient> clients;

        public int budget
        {
            get { return this._budget; }
            set { this._budget = value; }
        }

        public int salary
        {
            get { return this._salary; }
            set { this._salary = value; }
        }


        public Company(Employee participantCreator, string idea, int budget, List<Employee> team, int salary)
        {
            this.participantCreator = participantCreator;
            this.idea = idea;
            this.budget = budget;
            this.team = team;
            this.salary = salary;
            this.clients = new List<IClient>();
            participantCreator.SetCompany(this);
            foreach(IEmployee participant in team)
            {
                participant.SetCompany(this);
            }
        }

        public void Advertise(int adBudget)
        {
            if (this._budget - adBudget > 0)
            {
                this._budget = this._budget - adBudget;
            } else
            {
                Console.WriteLine("Too little money");
            }
        }

        public void AddParticipant(Employee participant)
        {
            this.team.Add(participant);
            participant.SetCompany(this);
        }

        public void SetSalary(int salary)
        {
            this._salary = salary;
        }

        public void AddClient(IClient client)
        {
            this.clients.Add(client);
        }

    }
}
