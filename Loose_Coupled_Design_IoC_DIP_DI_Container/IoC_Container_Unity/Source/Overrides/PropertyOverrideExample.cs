using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Resolution;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides
{
    //We learned about Property Injection. Here, we will learn how to override the
    //registered value of the specified property using PropertyOverride.

    //You can override a registered property injection and provide a different
    //property value when you resolve it.
    public class PropertyOverrideExample
    {
        public void Run()
        {
            var container = new UnityContainer();

            //Configure the default value of the Car property
            container.RegisterType<Driver>(new InjectionProperty("Car", new BMW()));

            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            //Override the default value of the Car property
            var driver2 = container.Resolve<Driver>(new PropertyOverride("Car", new Audi()));

            driver2.RunCar();
        }
    }
}
