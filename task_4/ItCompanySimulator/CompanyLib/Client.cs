using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class Client : IClient
    {
        private int _budget;
        private ICompany _company;

        public ICompany Company
        {
            set { _company = value; }
        }

        public Client()
        {
            _budget = 0;
        }
        public void GiveFeedback()
        {
            if (_budget < 0)
            {
                Console.WriteLine("Very bad, everything is very bad");
            } else
            {
                Console.WriteLine("Everything is not bad, but your it specialist is not quite good");
            }
        }

        public void PayMoney(int payment)
        {
            _budget = _budget - payment;
            _company.Budget = _company.Budget + payment;
        }
    }
}
