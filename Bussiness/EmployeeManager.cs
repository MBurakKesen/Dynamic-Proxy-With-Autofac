using ConsoleProxy.Proxies;
using Entities.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class EmployeeManager: IEmployeeService
    {
        [InvocationAspect(Priority =1)]
        public virtual void  Add(IEmployee employee) { }
    }
}
