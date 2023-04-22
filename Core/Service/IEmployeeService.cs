using Entities.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public interface IEmployeeService
    {
        void Add(IEmployee employee);
    }
}
