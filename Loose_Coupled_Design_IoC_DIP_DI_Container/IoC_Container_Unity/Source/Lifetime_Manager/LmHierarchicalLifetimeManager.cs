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
    //The HierarchicalLifetimeManager is the same as the ContainerControlledLifetimeManager, except
    //that if you create a child container then it will create its own singleton instance of the
    //registered type and will not share the instance with the parent container.
    public class LmHierarchicalLifetimeManager
    {
        public void Run()
        {
            var container = new UnityContainer().RegisterType<ICar, BMW>(new HierarchicalLifetimeManager());

            var childContainer = container.CreateChildContainer();

            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            var driver2 = container.Resolve<Driver>();
            driver2.RunCar();

            var driver3 = childContainer.Resolve<Driver>();
            driver3.RunCar();

            var driver4 = childContainer.Resolve<Driver>();
            driver4.RunCar();

            //As you can see, both container and childContainer have their own singleton instance of BMW.
        }
    }
}
