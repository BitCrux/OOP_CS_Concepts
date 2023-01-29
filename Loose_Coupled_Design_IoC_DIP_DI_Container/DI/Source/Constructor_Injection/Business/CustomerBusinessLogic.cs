using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Constructor_Injection.Persistence;
using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Constructor_Injection.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Constructor_Injection.Business
{
    //In this example, CustomerBusinessLogic includes the constructor with one parameter of type ICustomerDataAccess.
    //Now, the calling class must inject an object of ICustomerDataAccess.
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogic(ICustomerDataAccess custDataAccess)
        {
            _dataAccess = custDataAccess;
        }

        public CustomerBusinessLogic()
        {
            _dataAccess = new CustomerDataAccess();
        }

        public string ProcessCustomerData(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }
}
