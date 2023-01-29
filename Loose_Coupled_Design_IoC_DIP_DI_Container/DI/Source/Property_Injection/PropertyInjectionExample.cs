using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Property_Injection.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Property_Injection
{
    //In the property injection, the dependency is provided through a public property. Consider the following example.
    public class PropertyInjectionExample
    {
        public void Run()
        {
            CustomerService cs = new CustomerService();
            cs.GetCustomerName(4711);
        }
    }
}
