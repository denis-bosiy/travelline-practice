using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class BadClient : IClient
    {
        public void GiveFeedback()
        {
            Console.WriteLine("Very bad, everything is very bad");
        }
    }
}
