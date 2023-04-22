using Autofac;
using Autofac.Extras.DynamicProxy;
using Bussiness;
using Castle.DynamicProxy;
using Core.Interceptors;
using Entities.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Moduls
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var proxyOptions = new ProxyGenerationOptions
            {
                Selector = new AspectInterceptorSelector()
            };


            builder.RegisterType<Employee>().As<IEmployee>().EnableInterfaceInterceptors(proxyOptions).SingleInstance();
            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().EnableInterfaceInterceptors(proxyOptions).SingleInstance();
        }
    }

}