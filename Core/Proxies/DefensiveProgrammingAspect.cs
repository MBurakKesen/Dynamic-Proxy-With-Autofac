using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProxy.Proxies
{
    public class DefensiveProgrammingAspect : MehtodInterception
    {
        public override void onBefore(IInvocation invocation)
        {

            var paramatres = invocation.Arguments;
            foreach (var arg in paramatres)
            {
                if (arg.Equals(null))
                {
                    throw new ArgumentNullException();
                }
                Console.WriteLine("null check succseded");
            }

        }


    }
}
