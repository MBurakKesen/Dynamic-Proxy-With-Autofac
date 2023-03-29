using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxyLibrary
{
    public class InvocationAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            GetStarted(invocation);
            invocation.Proceed();
            GetFinished(invocation);
        }

        public  void GetStarted(IInvocation invocation)
        {
            Console.WriteLine("öncesi");
        }
        public  void GetFinished(IInvocation invocation)
        {
            Console.WriteLine("sonrası");
        }
    }
}
