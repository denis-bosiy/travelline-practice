using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public interface IEmployee
    {
        string name { get; set; }
        string position { get; set; }

        void GetSalary();
        void SetCompany(ICompany company);
    }
}
