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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public Employee(string employeeName, string employeePosition)
        {
            _name = employeeName;
            _position = employeePosition;
        }

        public void GetSalary()
        {
            if (_company.Budget <= 0)
            {
                Console.WriteLine("Sorry, today is a not a payday! Ахах");
            } else if (_company.Salary > 0)
            {
                Console.WriteLine("Hooray, i got salary = " + _company.Salary);
                _company.Budget -= _company.Salary;
            } else
            {
                Console.WriteLine("Employee without company!");
            }
        }
        public void SetCompany(ICompany company)
        {
            _company = company;
        }
    }
}
