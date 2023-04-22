using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProxy.Proxies
{
    public class MyMethodInterceptorAspect : MehtodInterception
    {
        public override void onBefore(IInvocation invocation)
        {
            Console.WriteLine("oncesi method çalışıyor");

        }

        public override void onAfter(IInvocation invocation)
        {
            Console.WriteLine("method sonrası çalışıyor");
        }
    }
}
