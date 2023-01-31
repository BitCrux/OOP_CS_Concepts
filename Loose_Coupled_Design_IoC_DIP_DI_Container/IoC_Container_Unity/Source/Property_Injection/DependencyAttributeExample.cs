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
    //Property injection is a type of dependency injection where dependencies are provided through properties.

    //the Driver class is dependent on a property of type ICar. So, we need to set an object of
    //a class that implements ICar to the Car property using Unity container.

    //Property injection in Unity container can be implemented in two ways:
        //Using the[Dependency] attribute
        //Using run-time configuration
    public class DependencyAttributeExample
    {
        public void Run()
        {
            //For the property injection, we first tell the Unity container which property to inject.
            //So, we need to decorate the dependent properties with the [Dependency] attribute, as shown in the following Driver2 class.

            //Now, we can register the ICar type and resolve it as shown below.

            var container = new UnityContainer();
            container.RegisterType<ICar, BMW>();

            var driver = container.Resolve<Driver1>();
            driver.RunCar();
        }
    }
}
