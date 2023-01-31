using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Property_Injection.Models;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Property_Injection.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Property_Injection
{
    public class PiNamedMappingExample
    {
        public void Run()
        {
            //We can specify a name in the[Dependency("name")] attribute, which can then be used to set the property value.

            var container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("LuxuryCar");

            var driver = container.Resolve<Driver2>();
            driver.RunCar();
        }
    }
}
