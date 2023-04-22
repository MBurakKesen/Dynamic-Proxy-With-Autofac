using Autofac;
using Bussiness;
using ConsoleProxy.Proxies;
using Core.Moduls;
using Entities.entities;
using System;

namespace Console
{
    public class Program
    {
      
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new DefaultModule());
            var container = builder.Build();
            var willBeIntercepted = container.Resolve<IEmployeeService>();
            willBeIntercepted.Add(new Employee { firstName = "Burak", lastName = "Kesen", id = 1 });


        }

    }
}
