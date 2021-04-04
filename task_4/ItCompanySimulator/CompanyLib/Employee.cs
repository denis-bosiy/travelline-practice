using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class Employee : IEmployee
    {
        private ICompany _company;
        private string _name;
        private string _position;

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
                Console.WriteLine("Sorry, today is a not a payday! Ахах");
            } else if (_company.salary > 0)
            {
                Console.WriteLine("Hooray, i got salary = " + _company.salary);
                _company.budget -= _company.salary;
            } else
            {
                Console.WriteLine("Employee without company!");
            }
        }
        public void SetCompany(ICompany company)
        {
            this._company = company;
        }
    }
}
