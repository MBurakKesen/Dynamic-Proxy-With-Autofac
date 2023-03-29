using Castle.DynamicProxy;
using dynamicProxyDemo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxyLibrary
{
    public class DefensiveProgrammingAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            NullCheck(invocation);
            invocation.Proceed();
        }

        private void NullCheck(IInvocation invocation)
        {
            var paramatres = invocation.Arguments;
            foreach (var arg in paramatres)
            {
                if (arg.Equals(null))
                {
                    throw new ArgumentNullException();
                    Console.WriteLine("");
                }
                Console.WriteLine("null check succseded");
            }
        }
    }
}
