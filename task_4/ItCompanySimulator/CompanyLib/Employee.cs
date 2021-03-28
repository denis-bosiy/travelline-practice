using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class Employee : IEmployee
    {
        ICompany _company;

        string _name;
        string _position;

        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public string position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        public Employee(string employeeName, string employeePosition)
        {
            _name = employeeName;
            _position = employeePosition;
        }

        public void GetSalary()
        {
            if (_company.budget <= 0)
            {
                Console.WriteLine("Извини, сегодня без зарплаты! Ахах");
            } else if (_company.salary > 0)
            {
                Console.WriteLine("Ура, я получил зп = " + this._company.salary);
                this._company.budget = this._company.budget - this._company.salary;
            } else
            {
                Console.WriteLine("Сотрудник без труда!");
            }
        }

        public void SetCompany(ICompany company)
        {
            this._company = company;
        }
    }
}
