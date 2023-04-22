using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProxy.Proxies
{
    public class InvocationAspect : MehtodInterception
    {
        public override void onBefore(IInvocation invocation)
        {
            Console.WriteLine($"{invocation.Method.Name}   :Method ismi");
            Console.WriteLine($"{invocation.Method.ReturnParameter}   :Method un geri dönüş değeri");
            Console.WriteLine($"{invocation.Proxy}   :Kullanılan proxy ");
        }

        public override void onAfter(IInvocation invocation)
        {
            Console.WriteLine("method çalıştı");
        }

    }
}
