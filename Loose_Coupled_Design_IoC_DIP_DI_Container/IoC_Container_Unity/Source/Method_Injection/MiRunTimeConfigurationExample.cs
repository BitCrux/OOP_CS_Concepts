using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Method_Injection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Method_Injection
{
    //Unity container allows us to configure method injection with the RegisterType() method
    //if a method is not marked with the [InjectionMethod] attribute. Pass an object of the
    //InjectionMethod class in the RegisterType() method to specify a method name and a parameter value.
    public class MiRunTimeConfigurationExample
    {
        public void Run()
        {
            var container = new UnityContainer();

            //run-time configuration
            container.RegisterType<Driver1>(new InjectionMethod("UseCar", new Audi()));

            //to specify multiple parameters values
            container.RegisterType<Driver1>(new InjectionMethod("UseCar", new object[] { new Audi() }));

            var driver = container.Resolve<Driver1>();
            driver.RunCar();

            //As you can see in the above example, container.RegisterType<driver>(new InjectionMethod("UseCar", new Audi())) registers
            //the Driver1 class by passing an object of the InjectionMethod that specifies the method name and the parameter value.
            //So, Unity container will inject an object of Audi when we resolve it using container.Resolve<Driver1>().
        }
    }
}
