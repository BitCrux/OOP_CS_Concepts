using Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction
{
    //https://www.tutorialsteacher.com/ioc/dependency-inversion-principle

    //With IoC, we learned about implementing the IoC principle using the Factory pattern and achieved the
    //first level of loosely coupled design. Here, we will learn how to implement the Dependency Inversion
    //Principle as the second step to achieve loosely coupled classes.

    //DIP Definition
    //High-level modules should not depend on low-level modules.Both should depend on the abstraction.
    //Abstractions should not depend on details. Details should depend on abstractions.

    //As per the DIP definition, a high-level module should not depend on low-level modules. Both should
    //depend on abstraction. So, first, decide which is the high-level module (class) and the low-level module.
    //A high-level module is a module which depends on other modules. In our example, CustomerBusinessLogic
    //depends on the DataAccess class, so CustomerBusinessLogic is a high-level module and DataAccess is a
    //low-level module. So, as per the first rule of DIP, CustomerBusinessLogic should not depend on the
    //concrete DataAccess class, instead both classes should depend on abstraction.

    //The second rule in DIP is "Abstractions should not depend on details. Details should depend on abstractions".

    //What is an Abstraction?

    //Abstraction and encapsulation are important principles of object-oriented programming.There are many different
    //definitions from different people, but let's understand abstraction using the above example.

    //In English, abstraction means something which is non-concrete.In programming terms, the above CustomerBusinessLogic
    //and DataAccess are concrete classes, meaning we can create objects of them.So, abstraction in programming means to
    //create an interface or an abstract class which is non-concrete.This means we cannot create an object of an interface
    //or an abstract class. As per DIP, CustomerBusinessLogic(high-level module) should not depend on the concrete DataAccess
    //class (low-level module). Both classes should depend on abstractions, meaning both classes should depend on an interface
    //or an abstract class.
    public class DIPExample
    {
        public void Run()
        {
            CustomerBusinessLogic cbl = new CustomerBusinessLogic();
            cbl.GetCustomerName(4711);

            //Thus, we have implemented DIP in our example where a high-level module (CustomerBusinessLogic) and low-level module
            //(CustomerDataAccess) are dependent on an abstraction (ICustomerDataAccess). Also, the abstraction (ICustomerDataAccess)
            //does not depend on details (CustomerDataAccess), but the details depend on the abstraction.

            //The advantages of implementing DIP in the above example is that the CustomerBusinessLogic and CustomerDataAccess classes
            //are loosely coupled classes because CustomerBusinessLogic does not depend on the concrete DataAccess class, instead it
            //includes a reference of the ICustomerDataAccess interface. So now, we can easily use another class which implements
            //ICustomerDataAccess with a different implementation.
        }
    }
}
