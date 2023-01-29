using Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction.Persistence.Factories
{
    //Now, we need to change our factory class which returns ICustomerDataAccess instead of
    //the concrete DataAccess class, as shown below.
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
}
