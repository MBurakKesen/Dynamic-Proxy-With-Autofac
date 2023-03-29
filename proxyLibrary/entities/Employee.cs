using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicProxyDemo.entities
{
    public class Employee
    {

        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void Add(Employee entity)
        {
            Console.WriteLine($"{entity.id} : id niz");
            Console.WriteLine($"{entity.lastName}");
            Console.WriteLine($"{entity.firstName} :");
            Console.WriteLine("soy isminiz");
        }
    }
}
