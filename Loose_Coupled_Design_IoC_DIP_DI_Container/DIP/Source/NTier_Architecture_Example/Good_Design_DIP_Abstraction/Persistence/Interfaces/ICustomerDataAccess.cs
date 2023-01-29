using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction.Persistence.Interfaces
{
    //Now, what should be in the interface (or in the abstract class)? As you can see, CustomerBusinessLogic
    //uses the GetCustomerName() method of the DataAccess class (in real life, there will be many customer-related
    //methods in the DataAccess class). So, let's declare the GetCustomerName(int id) method in the interface, as shown below.
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
}
