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
    //Use the ContainerControlledLifetimeManager when you want to create a singleton instance.
    public class LmContainerControlledLifetimeManager
    {
        public void Run()
        {
            var container = new UnityContainer().RegisterType<ICar, BMW>(new ContainerControlledLifetimeManager());

            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            var driver2 = container.Resolve<Driver>();
            driver2.RunCar();

            //In the above example, we specified ContainerControlledLifetimeManager in the RegisterType() method.
            //So, Unity container will create a single instance of the BMW class and inject it in all the instances of Driver.
        }
    }
}
