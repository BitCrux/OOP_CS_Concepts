using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Register_Resolve.Models;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Register_Resolve.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Register_Resolve
{
    //In order to use Unity container, we first need to create an object of it. You can use any class which
    //implements the IUnityContainer interface.
    public class RegisterResolveExample
    {
        public void Run()
        {
            IUnityContainer container = new UnityContainer();
            //or
            //var container = new UnityContainer();

            //Register
            container.RegisterType<ICar, BMW>();// Map ICar with BMW 

            //So now, after registration, we can use the Resolve() method

            //Resolves dependencies and returns the Driver object 
            Driver drv = container.Resolve<Driver>();
            drv.RunCar();

            //Unity container will create a new object and inject it every time we resolve the same type.
            Driver driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            Driver driver2 = container.Resolve<Driver>();
            driver2.RunCar();

            //In the above example, container injects the BMW object whenever it resolves the Driver class, e.g.
            //driver1 and driver2 both have references to separate BMW objects.
        }
    }
}
