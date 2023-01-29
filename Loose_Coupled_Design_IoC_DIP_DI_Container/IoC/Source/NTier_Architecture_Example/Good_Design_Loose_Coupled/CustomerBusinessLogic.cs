using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.NTier_Architecture_Example.Good_Design_Loose_Coupled
{
    //Now, use this DataAccessFactory class in the CustomerBusinessLogic class to get an object of DataAccess class.
    public class CustomerBusinessLogic
    {
        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            DataAccess _dataAccess = DataAccessFactory.GetDataAccessObj();

            return _dataAccess.GetCustomerName(id);
        }
    }
    //As you can see, the CustomerBusinessLogic class uses the DataAccessFactory.GetCustomerDataAccessObj() method
    //to get an object of the DataAccess class instead of creating it using the new keyword. Thus, we have inverted
    //the control of creating an object of a dependent class from the CustomerBusinessLogic class to the DataAccessFactory class.

    //This is a simple implementation of IoC and the first step towards achieving fully loose coupled design.As mentioned
    //in the previous chapter, we will not achieve complete loosely coupled classes by only using IoC. Along with IoC, we
    //also need to use DIP, Strategy pattern, and DI(Dependency Injection).
}
