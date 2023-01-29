using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.NTier_Architecture_Example.Good_Design_Loose_Coupled
{
    //In an object-oriented design, classes should be designed in a loosely coupled way.
    //Loosely coupled means changes in one class should not force other classes to
    //change, so the whole application can become maintainable and extensible.

    //In the typical n-tier architecture, the User Interface (UI) uses Service layer to retrieve or save data.
    //The Service layer uses the BusinessLogic class to apply business rules on the data. The BusinessLogic
    //class depends on the DataAccess class which retrieves or saves the data to the underlying database.
    //This is simple n-tier architecture design. Let's focus on the BusinessLogic and DataAccess classes to understand IoC.

    //The following is an example of BusinessLogic and DataAccess classes for a customer.

    //The following pattern (but not limited) implements the IoC principle.
    public class GoodDesignLooseCoupledExample
    {
        public void Run()
        {
            CustomerBusinessLogic cbl = new CustomerBusinessLogic();
            cbl.GetCustomerName(4711);
        }
    }
}
