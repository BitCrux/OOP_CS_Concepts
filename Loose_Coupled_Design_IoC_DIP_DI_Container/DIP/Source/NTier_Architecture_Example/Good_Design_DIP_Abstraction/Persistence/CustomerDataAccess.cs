using Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction.Persistence
{
    //Now, implement ICustomerDataAccess in the CustomerDataAccess class, as shown
    //below (so, instead of the DataAccess class, let's define the new CustomerDataAccess class).
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }
}
