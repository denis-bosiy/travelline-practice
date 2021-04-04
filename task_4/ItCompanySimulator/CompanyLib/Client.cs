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

        public ICompany company
        {
            set { this._company = value; }
        }

        public Client()
        {
            this._budget = 0;
        }
        public void GiveFeedback()
        {
            if (this._budget < 0)
            {
                Console.WriteLine("Very bad, everything is very bad");
            } else
            {
                Console.WriteLine("Everything is not bad, but your it specialist is not quite good");
            }
        }

        public void PayMoney(int payment)
        {
            this._budget = this._budget - payment;
            this._company.budget = this._company.budget + payment;
        }
    }
}
