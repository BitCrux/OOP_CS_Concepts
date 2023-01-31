using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Method_Injection.Models;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Method_Injection.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Method_Injection
{
    //In the method injection, dependencies are provided through method parameters.

    //As you can see in the above sample classes, the Driver class includes the method UseCar()
    //to set the object of type ICar. Here, we have taken a simple method example.

    //Method injection in Unity can be implemented in two ways:

    //Using the[InjectionMethod] attribute
    //Using run-time configuration

    //InjectionMethod Attribute
    //For the method injection, we need to tell the Unity container which method should be
    //used for dependency injection. So, we need to decorate a method with
    //the [InjectionMethod] attribute as shown in the following Driver class.
    public class MiAttributeExample
    {
        public void Run()
        {
            //We can implement method injection in Unity container as shown below.
            var container = new UnityContainer();
            container.RegisterType<ICar, BMW>();

            var driver = container.Resolve<Driver1>();
            driver.RunCar();
        }
    }
}
