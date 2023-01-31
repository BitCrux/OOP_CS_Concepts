using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection
{
    public class CiMultipleConstructors
    {
        public void Run()
        {
            //If a class includes multiple constructors, then use the [InjectionConstructor] attribute
            //to indicate which constructor to use for construction injection.

            //As you can see, the Driver3 class includes two constructors. So, we have used the [InjectionConstructor] attribute
            //to indicate which constructor to call when resolving the Driver class.

            //You can configure the same thing as above at run time instead of applying the[InjectionConstructor] attribute by passing
            //an object of the InjectionConstructor in the RegisterType() method, as shown below.
            var container = new UnityContainer();
            container.RegisterType<Driver3>(new InjectionConstructor(new Ford()));

            //or 

            //container.RegisterType<ICar, Ford>();
            //container.RegisterType<Driver3>(new InjectionConstructor(container.Resolve<ICar>()));

            var driver = container.Resolve<Driver3>();
            driver.RunCar();
        }
    }
}
