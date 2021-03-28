using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class GoodClient : IClient
    {
        public void GiveFeedback()
        {
             Console.WriteLine("Everything is not bad, but your it specialist is not quite good");
        }
    }
}
