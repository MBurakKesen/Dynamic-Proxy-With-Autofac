using Castle.DynamicProxy;
using dynamicProxyDemo.entities;
using proxyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicProxyDemo
{
    public class program
    {
       static void Main()
        {
            var proxy = new ProxyGenerator();  

            var aspect = proxy.CreateClassProxy<Employee>(new MyMethodInterceptorAspect());

            aspect.Add(new Employee { firstName = "Burak", lastName = "Kesen", id = 1 });

            Employee emp2 = new Employee();
            emp2.id = 1;
            emp2.firstName = "Muhammed";
            emp2.lastName = "Kesen";
            aspect.Add(emp2);
        }
    }
}
