using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Method_Injection.Business;
using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Method_Injection.Persistence;
using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Method_Injection.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Method_Injection.Service
{
    //In the above example, the CustomerBusinessLogic class implements the IDataAccessDependency
    //interface, which includes the SetDependency() method. So, the injector class CustomerService
    //will now use this method to inject the dependent class (CustomerDataAccess) to the client class.

    //Thus, you can use DI and strategy pattern to create loose coupled classes.
    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic();
            ((IDataAccessDependency)_customerBL).SetDependency(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }
    }
}
