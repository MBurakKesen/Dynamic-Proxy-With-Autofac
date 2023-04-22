using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.entities
{
    public class Employee:IEmployee
    {

        public int? id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }

        
    }
}
