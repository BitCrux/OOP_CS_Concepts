using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Property_Injection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Property_Injection
{
    //Unity container allows us to configure a property injection with the RegisterType() method
    //if a method is not marked with the [Dependency] attribute. You can pass an object of the
    //InjectionProperty class in the RegisterType() method to specify a property name and a parameter value.
    public class PiRunTimeConfigurationExample
    {
        public void Run()
        {
            var container = new UnityContainer();

            //run-time configuration
            container.RegisterType<Driver1>(new InjectionProperty("Car", new BMW()));

            var driver = container.Resolve<Driver1>();
            driver.RunCar();

            //As you can see in the above example, container.RegisterType<driver>(new InjectionProperty("Car", new BMW()))
            //registers the Driver1 class by passing an object of InjectionProperty that specifies the property
            //name "Car" and the BMW object as a value. Therefore, Unity container will set an object of BMW to
            //the Car property when we resolve it using container.Resolve<Driver1>().
        }
    }
}
