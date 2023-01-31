using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides.Models;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Resolution;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides
{
    //The ParameterOverride can be used to override registered construction parameter values.
    public class ParameterOverrideExample
    {
        public void Run()
        {
            var container = new UnityContainer().RegisterType<ICar, BMW>();

            var driver1 = container.Resolve<Driver>(); // Injects registered ICar type
            driver1.RunCar();

            // Overrides the registered ICar type 
            var driver2 = container.Resolve<Driver>(new ParameterOverride("car", new Ford()));
            driver2.RunCar();

            //In the above example, Unity container injects BMW in driver1 which is default mapping.
            //However, we override the default mapping and specify a different mapping for driver2
            //by passing new ParameterOverride("car", new Ford()) into the Resolve() method.
            //The first parameter is the name of the constructor parameter and the second is the value
            //of the parameter. So, driver2 includes an object of the Ford class instead of the BMW class.

            //If a constructor includes multiple parameters, then we can override them by
            //passing an array of ResolverOverride as shown below.

            //driver2 = container.Resolve<Driver>(new ResolverOverride[] {
            //    new ParameterOverride("car1", new Ford()),
            //    new ParameterOverride("car2", new BMW()),
            //    new ParameterOverride("car3", new Audi())
            //    });
            //driver2.RunCar();
        }
    }
}
