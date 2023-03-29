using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interceptors
{
    public  class MehtodInterception:MethodInterceptorsBaseAttribute
    {
        public override void Intercept(IInvocation invocation)
        {
            bool successFlag = true;
            onBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                successFlag = false;
                onException(invocation,e);
                throw;
            }
            finally
            {
                if (successFlag)
                {
                    onSuccess(invocation);
                }
            }
            onAfter(invocation);

        }
        public virtual void onBefore(IInvocation invocation)
        {

        } public virtual void onAfter(IInvocation invocation)
        {

        } 
        public virtual void onException(IInvocation invocation,Exception e)
        {

        } 
        public virtual void onSuccess(IInvocation invocation)
        {

        }
    }
}
