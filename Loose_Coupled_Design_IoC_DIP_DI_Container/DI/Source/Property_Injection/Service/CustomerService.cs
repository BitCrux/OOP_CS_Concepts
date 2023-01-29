using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Property_Injection.Business;
using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Property_Injection.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Property_Injection.Service
{
    //As you can see above, the CustomerBusinessLogic class includes the public property named
    //DataAccess, where you can set an instance of a class that implements ICustomerDataAccess.
    //So, CustomerService class creates and sets CustomerDataAccess class using this public property.
    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic();
            _customerBL.DataAccess = new CustomerDataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }
    }
}
