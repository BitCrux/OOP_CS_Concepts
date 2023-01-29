using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Constructor_Injection.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Constructor_Injection
{
    //As mentioned before, when we provide the dependency through the constructor, this is called a constructor injection.

    //Consider the following example where we have implemented DI using the constructor.
    public class ConstructorInjectionExample
    {
        public void Run()
        {
            CustomerService cs = new CustomerService();
            cs.GetCustomerName(4711);
        }
    }
}
