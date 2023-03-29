using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxyLibrary
{
    public class MyMethodInterceptorAspect:MehtodInterception
    {
        public override void onBefore(IInvocation invocation)
        {
            Console.WriteLine("öncesi çalıştı");
        }
        public override void onAfter(IInvocation invocation)
        {
            Console.WriteLine("sonrası çalıştı");
        }
    }
}
