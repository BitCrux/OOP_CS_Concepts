using Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction.Persistence;
using Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction.Persistence.Factories;
using Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction.Business
{
    //Now, change the CustomerBusinessLogic class which uses ICustomerDataAccess
    //instead of the concrete DataAccess, class as shown below.
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess;

        public CustomerBusinessLogic()
        {
            _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }
}
