using Castle.Components.DictionaryAdapter.Xml;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptos)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptorsBaseAttribute>(true).ToList();

            var methodAttributes = type.GetMethod(method.Name)?.GetCustomAttributes<MethodInterceptorsBaseAttribute>(true);

            if (methodAttributes is not null)
            {
                classAttributes.AddRange(methodAttributes);
            }
            return classAttributes.OrderBy(p => p.Priority).ToArray();
        }
    }
}
