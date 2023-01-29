using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.NTier_Architecture_Example.Bad_Design_Tight_Coupled
{
    //In the typical n-tier architecture, the User Interface (UI) uses Service layer to retrieve or save data.
    //The Service layer uses the BusinessLogic class to apply business rules on the data. The BusinessLogic
    //class depends on the DataAccess class which retrieves or saves the data to the underlying database.
    //This is simple n-tier architecture design. Let's focus on the BusinessLogic and DataAccess classes to understand IoC.

    //The following is an example of BusinessLogic and DataAccess classes for a customer.
    public class BadDesignTightCoupledExample
    {
        public void Run()
        {
            CustomerBusinessLogic cbl = new CustomerBusinessLogic();
            cbl.GetCustomerName(4711);

            //As you can see in the above example, the CustomerBusinessLogic class depends on the DataAccess class.
            //It creates an object of the DataAccess class to get the customer data.

            //Now, let's understand what's wrong with the above classes.

            //In the above example, CustomerBusinessLogic and DataAccess are tightly coupled classes because the CustomerBusinessLogic
            //class includes the reference of the concrete DataAccess class. It also creates an object of DataAccess
            //class and manages the lifetime of the object.

            //Problems in the above example classes:

                //CustomerBusinessLogic and DataAccess classes are tightly coupled classes. So, changes in the DataAccess
                //class will lead to changes in the CustomerBusinessLogic class. For example, if we add, remove or rename
                //any method in the DataAccess class then we need to change the CustomerBusinessLogic class accordingly.
            
                //Suppose the customer data comes from different databases or web services and, in the future, we may
                //need to create different classes, so this will lead to changes in the CustomerBusinessLogic class.
            
                //The CustomerBusinessLogic class creates an object of the DataAccess class using the new keyword.
                //There may be multiple classes which use the DataAccess class and create its objects.So, if you
                //change the name of the class, then you need to find all the places in your source code where you
                //created objects of DataAccess and make the changes throughout the code.This is repetitive code
                //for creating objects of the same class and maintaining their dependencies.
            
                //Because the CustomerBusinessLogic class creates an object of the concrete DataAccess class, it
                //cannot be tested independently(TDD). The DataAccess class cannot be replaced with a mock class.

            //To solve all of the above problems and get a loosely coupled design, we can use the IoC and
            //DIP principles together.
        }
    }
}
