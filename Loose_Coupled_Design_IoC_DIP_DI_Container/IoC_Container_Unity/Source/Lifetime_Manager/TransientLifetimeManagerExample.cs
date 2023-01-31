using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Lifetime_Manager.Models;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Lifetime_Manager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Lifetime_Manager
{
    //The TransientLifetimeManager is the default lifetime manager. It creates a new
    //object of the requested type every time you call the Resolve() or ResolveAll() method.
    public class TransientLifetimeManagerExample
    {
        public void Run()
        {
            var container = new UnityContainer().RegisterType<ICar, BMW>();

            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            var driver2 = container.Resolve<Driver>();
            driver2.RunCar();

            //In the above example, Unity container will create two new instances of the BMW class
            //and will inject into the driver1 and driver2 objects. This is because the default
            //lifetime manager is TransientLifetimeManager, which creates a new dependent object
            //every time you call the Resolve() or ResolveAll() method. You can specify the
            //lifetime manager when registering the type using the RegisterType() method.

            //The following example will display the same output as in above example because
            //TransientLifetimeManager is the default manager, if not specified.

            container = new UnityContainer().RegisterType<ICar, BMW>(new TransientLifetimeManager());

            driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            driver2 = container.Resolve<Driver>();
            driver2.RunCar();
        }
    }
}
