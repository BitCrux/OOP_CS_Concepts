using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Constructor_Injection.Business;
using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Constructor_Injection.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Constructor_Injection.Service
{
    //As you can see in the above example, the CustomerService class creates and injects the
    //CustomerDataAccess object into the CustomerBusinessLogic class. Thus, the CustomerBusinessLogic
    //class doesn't need to create an object of CustomerDataAccess using the new keyword or using
    //factory class. The calling class (CustomerService) creates and sets the appropriate DataAccess class
    //to the CustomerBusinessLogic class. In this way, the CustomerBusinessLogic and CustomerDataAccess
    //classes become "more" loosely coupled classes.
    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.ProcessCustomerData(id);
        }
    }
}
