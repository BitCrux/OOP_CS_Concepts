using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Register_Resolve.Models;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Register_Resolve.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Register_Resolve
{
    public class RegisterNamedTypeExample
    {
        public void Run()
        {
            //You can register a type-mapping with a name which you can use with the Resolve() method.
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("LuxuryCar");

            ICar bmw = container.Resolve<ICar>();  // returns the BMW object
            ICar audi = container.Resolve<ICar>("LuxuryCar"); // returns the Audi object
            //As you can see above, we have mapped ICar with both the BMW and the Audi class. However, we
            //have given the name "LuxuryCar" to the ICar-Audi mapping. So now, the Resolve() method
            //will return an object of Audi if we specify the mapping name.

            //Consider the following example:
            container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("LuxuryCar");

            // Registers Driver type            
            container.RegisterType<Driver>("LuxuryCarDriver",
                            new InjectionConstructor(container.Resolve<ICar>("LuxuryCar")));

            Driver driver1 = container.Resolve<Driver>();// injects BMW
            driver1.RunCar();

            Driver driver2 = container.Resolve<Driver>("LuxuryCarDriver");// injects Audi
            driver2.RunCar();
            //In the above example, we registered the Driver class with the name "LuxuryCarDriver" and specified
            //an object of InjectionConstructor. The new InjectionConstructor(container.Resolve<ICar>("LuxuryCar"))
            //specifies a construction injection for the Driver class, which passes an object of Audi because
            //container.Resolve("LuxuryCar") returns an Audi object. So now, we can use container.Resolve<Driver>("LuxuryCarDriver")
            //to resolve the Driver with Audi even if ICar is registered with BMW by default.
        }
    }
}
