using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection
{
    public class ConstructorInjectionExample
    {
        public void Run()
        {
            var container = new UnityContainer();
            container.RegisterType<ICar, BMW>();

            //By default, Resolve<T>() performs construction injection to inject dependencies and returns an object of the specified type.
            var driver = container.Resolve<Driver1>();
            driver.RunCar();
            //Driver1 class accepts an object of type ICar in the constructor. So, Unity container will
            //inject dependencies via the constructor as shown below.

            //In the above example, container.RegisterType<ICar, BMW>() maps ICar to BMW. It means that whenever Unity container
            //needs to inject an object of type ICar, it will create and inject an object of the BMW class. The container.Resolve<driver1>()
            //method will create and return an object of the Driver1 class by passing an object of ICar into the constructor. As we have
            //mapped ICar to BMW, it will create and inject a BMW object to a constructor of the Driver1 class and return an object of the Driver1 class.

            //Thus, by default, the Resolve() method performs constructor injection while resolving types.
        }
    }
}
