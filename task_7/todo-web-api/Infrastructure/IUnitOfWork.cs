using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_web_api.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
