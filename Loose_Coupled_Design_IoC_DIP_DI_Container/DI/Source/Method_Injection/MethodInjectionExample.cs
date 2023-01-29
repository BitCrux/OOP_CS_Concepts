using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Method_Injection.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Method_Injection
{
    //n the method injection, dependencies are provided through methods. This method can be a class method or an interface method.

    //The following example demonstrates the method injection using an interface based method.
    public class MethodInjectionExample
    {
        public void Run()
        {
            CustomerService cs = new CustomerService();
            cs.GetCustomerName(4711);
        }
        //So far, we have used several principles and patterns to achieve loosely coupled classes.
        //In professional projects, there are many dependent classes and implementing these patterns is
        //time consuming. Here the IoC Container (aka the DI container) helps us.
    }
}
