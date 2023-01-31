using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection
{
    public class CiPrimitiveTypeParameterExample
    {
        public void Run()
        {
            //Unity also injects primitive type parameters in the constructor.
            //Consider the following Driver4 class with primitive type parameters in the constructor.

            //Use the InjectionConstructor class to configure the constructor's parameter values.
            //Pass an object of the InjectionConstructor class in the RegisterType() method to specify multiple parameters values.

            var container = new UnityContainer();

            container.RegisterType<Driver4>(new InjectionConstructor(new object[] { new Audi(), "Steve" }));

            var driver = container.Resolve<Driver4>(); // Injects Audi and Steve
            driver.RunCar();
        }
    }
}
